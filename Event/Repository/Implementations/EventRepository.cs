using Event.DTOs;
using Event.EventModel;
using Event.Repository.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;

namespace Event.Repository.Implementations
{
    public class EventRepository : GenericRepository<EventEntity>, IEventRepository
    {
        private readonly EventContext _dbContext;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _environment;


        public EventRepository(EventContext dbcontext, IUnitOfWork unitOfWork, IWebHostEnvironment environment)
            : base(dbcontext, unitOfWork)
        {
            _dbContext = dbcontext;
            _unitOfWork = unitOfWork;
            _environment = environment;
        }

        public async Task SubmitAsync(EventEntity eventData)
        {
            var approvalList = new List<EventApproval>();

            var approvalDepartment = await _dbContext.ApprovalSchemas
                .Where(e => e.DepName == eventData.ApprovingDeptName)
                .FirstOrDefaultAsync();

            if (approvalDepartment == null)
            {
                throw new Exception("Department not found");
            }

            int? firstApprovalID = approvalDepartment.FirstApprovalLevelId;
            int? secondApprovalID = approvalDepartment.SecondApprovalLevelId;

            int? firstUserTypeId = await _dbContext.Users
                .Where(e => e.EmpId == firstApprovalID)
                .Select(e => e.UserTypeId)
                .FirstOrDefaultAsync();

            int? secondUserTypeId = await _dbContext.Users
                .Where(e => e.EmpId == secondApprovalID)
                .Select(e => e.UserTypeId)
                .FirstOrDefaultAsync();


            approvalList.Add(new EventApproval
            {
                EventId = eventData.EventId,
                EmpId = firstApprovalID,
                UserTypeId = firstUserTypeId,
                IsApprove = 1,
                CreatedAt = DateTime.UtcNow
            });

           
          approvalList.Add(new EventApproval
            {
                EventId = eventData.EventId,
                EmpId = secondApprovalID,
                UserTypeId = secondUserTypeId,
                IsApprove = 1,
                CreatedAt = DateTime.UtcNow
            });

            if (eventData.IsOthers == 1)
            {
                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 6841,
                    UserTypeId = 3,
                    IsApprove = 1,
                    CreatedAt = DateTime.UtcNow
                });

                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 3960,
                    UserTypeId = 4,
                    IsApprove = 1,
                    CreatedAt = DateTime.UtcNow
                });
            }

            else
            {
                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 6841,
                    UserTypeId = 3,
                    IsApprove = 0,
                    CreatedAt = DateTime.UtcNow
                });
            }

            if (eventData.HasIt == 1)
            {
                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 7011,
                    UserTypeId = 6,
                    IsApprove = 1,
                    CreatedAt = DateTime.UtcNow
                });
            }
            else
            {
                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 7011,
                    UserTypeId = 6,
                    IsApprove = 0,
                    CreatedAt = DateTime.UtcNow
                });
            }

            

            var additionalApprovals = new List<EventApproval>
            {
                new EventApproval { EventId = eventData.EventId, EmpId = 7988, UserTypeId = 9, IsApprove = 1, CreatedAt = DateTime.UtcNow },
                new EventApproval { EventId = eventData.EventId, EmpId = 1118, UserTypeId = 14, IsApprove = 1, CreatedAt = DateTime.UtcNow },
                new EventApproval { EventId = eventData.EventId, EmpId = 7068, UserTypeId = 15, IsApprove = 1, CreatedAt = DateTime.UtcNow },
                new EventApproval { EventId = eventData.EventId, EmpId = 6792, UserTypeId = 16, IsApprove = 1, CreatedAt = DateTime.UtcNow }
            };

            approvalList.AddRange(additionalApprovals);

            // Save to database
            await _dbContext.EventApprovals.AddRangeAsync(approvalList);
            await _unitOfWork.Save();

            // Update existing event confirmation timestamp
            var existingRequest = await _dbContext.EventEntities
                .Where(e => e.EventId == eventData.EventId)
                .FirstOrDefaultAsync();

            if (existingRequest != null)
            {
                existingRequest.ConfirmedAt = DateTime.UtcNow;
                _dbContext.EventEntities.Update(existingRequest);
                await _unitOfWork.Save();
            }
        }


        public async Task<string?> SaveFileAsync(IFormFile? file, string folderPath)
        {
            if (file == null) return null;

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
                var filePath = Path.Combine(folderPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return $"/uploads/documents/{fileName}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
                return null;
            }
        }

        public async Task<(byte[] FileData, string ContentType)> GetFileAsync(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty.");
            }

            string fullPath = Path.Combine(_environment.WebRootPath, filePath);

            if (!System.IO.File.Exists(fullPath))
            {
                throw new FileNotFoundException("File not found.");
            }

            string contentType = GetContentType(fullPath);
            byte[] fileBytes = await File.ReadAllBytesAsync(fullPath);

            return (fileBytes, contentType);
        }

        private string GetContentType(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension switch
            {
                ".jpg" or ".jpeg" => "image/jpeg",
                ".png" => "image/png",
                ".pdf" => "application/pdf",
                ".doc" or ".docx" => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                _ => "application/octet-stream"
            };
        }

        public async Task<string?> ReplaceFileAsync(string? existingFilePath, IFormFile? newFile, string folderPath)
        {
            string? newFilePath = existingFilePath; // Default to existing file path

            if (newFile != null)
            {
                // Delete old file if it exists
                if (!string.IsNullOrEmpty(existingFilePath))
                {
                    var fullOldPath = Path.Combine("wwwroot", existingFilePath.TrimStart('/'));
                    if (File.Exists(fullOldPath))
                    {
                        File.Delete(fullOldPath);
                    }
                }

                // Save the new file
                newFilePath = await SaveFileAsync(newFile, folderPath);
            }

            return newFilePath;
        }

        public async Task<EventEntity> GetWithIncludes(int eventId)
        {
            var eventData = await _dbContext.EventEntities.Include(e => e.Transportations).
                Include(e => e.Accommodations).Include(e => e.ItcomponentEvents).FirstOrDefaultAsync();
            return eventData;
        }


    }
}
