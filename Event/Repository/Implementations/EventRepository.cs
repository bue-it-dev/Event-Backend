using Event.DTOs;
using Event.EventModel;
using Event.Models;
using Event.Repository.Interfaces;
using Event.Services.Interfaces;
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
        private readonly HrmDBContext _context;
        private readonly IMailService _mailService;



        public EventRepository(EventContext dbcontext, IUnitOfWork unitOfWork, IWebHostEnvironment environment, HrmDBContext context, IMailService mailService)
            : base(dbcontext, unitOfWork)
        {
            _dbContext = dbcontext;
            _unitOfWork = unitOfWork;
            _environment = environment;
            _context = context;
            _mailService = mailService;

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
                CreatedAt = DateTime.Now
            });

           
          approvalList.Add(new EventApproval
            {
                EventId = eventData.EventId,
                EmpId = secondApprovalID,
                UserTypeId = secondUserTypeId,
                IsApprove = 1,
                CreatedAt = DateTime.Now
            });

            if (eventData.IsOthers == 1)
            {
                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 6841, ///president for Approval
                    UserTypeId = 3,
                    IsApprove = 1,
                    CreatedAt = DateTime.Now
                });

                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 3960,  //Security Check
                    UserTypeId = 4,
                    IsApprove = 1,
                    CreatedAt = DateTime.Now
                });
            }

            else
            {
                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 6841,  //President for Acknowledgement
                    UserTypeId = 3,
                    IsApprove = 0,
                    CreatedAt = DateTime.Now
                });
            }
            if(eventData.IsChairBoardPrisidentVcb == 1)
            {
                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 7161, // public Affairs for Acknowledgement
                    UserTypeId = 5,
                    IsApprove = 0,
                    CreatedAt = DateTime.UtcNow
                });
            }

            if (eventData.HasIt == 1)
            {
                approvalList.Add(new EventApproval
                {
                    EventId = eventData.EventId,
                    EmpId = 7011, //IT for Approve
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
                    EmpId = 7011,  //IT for Acknowledgement
                    UserTypeId = 6,
                    IsApprove = 0,
                    CreatedAt = DateTime.UtcNow
                });
            }

            

            var additionalApprovals = new List<EventApproval>
            {
                new EventApproval { EventId = eventData.EventId, EmpId = 7988, UserTypeId = 9, IsApprove = 1, CreatedAt = DateTime.UtcNow }, //Budget
                new EventApproval { EventId = eventData.EventId, EmpId = 1118, UserTypeId = 14, IsApprove = 1, CreatedAt = DateTime.UtcNow }, //BO
                new EventApproval { EventId = eventData.EventId, EmpId = 7068, UserTypeId = 15, IsApprove = 1, CreatedAt = DateTime.UtcNow }, //EAF
                new EventApproval { EventId = eventData.EventId, EmpId = 6792, UserTypeId = 16, IsApprove = 1, CreatedAt = DateTime.UtcNow }  //COO
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
            var approvals = await _dbContext.EventApprovals.Where(e => e.EventId == eventData.EventId).FirstOrDefaultAsync();
            var userDetails = await _context.BueUsers.Where(e => e.EmpId == approvals.EmpId).FirstOrDefaultAsync();
            var SuperiorEmail = await _dbContext.Users.Where(e => e.UserName.ToLower().Trim() == userDetails.UserName.ToLower().Trim()).FirstOrDefaultAsync();
            MailRequest request = new MailRequest();
            request.ToEmail = SuperiorEmail.Email;
            request.Subject = "no-reply: New  Event Request for Your Action";
            var mailBody = @"<!DOCTYPE html>
                                                 <html>
                                                    <body>
                                                        <p><strong>Dear Mr./ Ms. <b>" + SuperiorEmail.UserName + @"</b>,
                                                            <br/><br/> We would like to inform you that a new Event request has been added to the EventSystem and requires your attention. 
                                                            <br/><br/> Please review the details at your earliest convenience. <br/><br/>
                                                            <br/><br/> To Access the EventSystem please <a href="""">Click Here</a>
                                                            <br/><br/> Thank you for your prompt attention to this matter.
                                                            <br/><br/> <span style=""color:#7f0008;"">Note: This is a no-reply email. please do not reply to this email.</span>
                                                            <br/><br/> Thanks, and Best Regards,
                                                    </body>
                                                </html>";
            request.Body = mailBody;
            await _mailService.SendEmailAsync(request);
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
            string? newFilePath = existingFilePath;

            try
            {
                if (newFile != null)
                {
                    // Delete old file if it exists
                    if (!string.IsNullOrEmpty(existingFilePath))
                    {
                        var fullOldPath = Path.GetFullPath(Path.Combine("wwwroot", existingFilePath.TrimStart('/')));
                        if (File.Exists(fullOldPath))
                        {
                            File.Delete(fullOldPath);
                        }
                    }

                    // Save the new file
                    newFilePath = await SaveFileAsync(newFile, folderPath);
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error replacing file: {ex.Message}");
                throw;
            }

            return newFilePath;
        }

        public async Task<EventEntity> GetWithIncludes(int eventId)
        {
            return await _dbContext.EventEntities
                .Include(e => e.Transportations)
                .Include(e => e.Accommodations)
                .Include(e => e.ItcomponentEvents)
                .FirstOrDefaultAsync(e => e.EventId == eventId);
        }


        public async Task DeleteFileAsync(string filePath)
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", filePath.TrimStart('/'));
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }

        public async Task<List<ApprovalSchema>> GetApprovalDepartmentSchema()
        {
            var departments = await _dbContext.ApprovalSchemas.ToListAsync();
            return departments;
        }

        public async Task<List<ItcomponentEvent>> GetItComponents()
        {
            var ItComponents = await _dbContext.ItcomponentEvents.ToListAsync();
            return ItComponents;
        }

        public async Task<IEnumerable<EventEntity>> GetEventsByEmpId(int empId)
        {
            var events = await _dbContext.EventEntities
                .Include(e => e.EventApprovals)
                .Where(e => e.EmpId == empId)
                .ToListAsync();

            return events;
        }

        public async Task SendEventAprovalEmail(int empId, int eventId, int status)
        {
            try
            {
                if (status == 1)
                {
                    var user = await _context.BueUsers.FirstOrDefaultAsync(u => u.EmpId == empId);
                    var SuperiorEmail = await _dbContext.Users.Where(e => e.UserName.ToLower().Trim() == user.UserName.ToLower().Trim()).FirstOrDefaultAsync();
                    MailRequest request = new MailRequest();
                    request.ToEmail = SuperiorEmail.Email;
                    request.Subject = "no-reply: New Event Request for Your Action";
                    var mailBody = @"<!DOCTYPE html>
                                     <html>
                                        <body>
                                            <p><strong>Dear Mr./ Ms. <b>" + SuperiorEmail.UserName + @"</b>,
                                                <br/><br/> We would like to inform you that a new Event request has been added to the EventSystem and requires your attention. 
                                                <br/><br/> Please review the details at your earliest convenience.
                                                <br/><br/> To Access the EventSystem please <a href="""">Click Here</a>
                                                <br/><br/> Thank you for your prompt attention to this matter.
                                                <br/><br/> <span style=""color:#7f0008;"">Note: This is a no-reply email. please do not reply to this email.</span>
                                                <br/><br/> Thanks, and Best Regards,
                                        </body>
                                    </html>";
                    request.Body = mailBody;
                    await _mailService.SendEmailAsync(request);

                    //Email Send to Requester
                    var requestDetails = await _dbContext.EventEntities.Where(e => e.EventId== eventId).FirstOrDefaultAsync();
                    var userdetails = await _context.BueEmpEmployees.Where(e => e.Id == requestDetails.EmpId).FirstOrDefaultAsync();
                        var requesterEmail = userdetails.Fname + " " + userdetails.Mname + " " + userdetails.Lname;
                        var userrequest = new MailRequest();
                        userrequest.ToEmail = SuperiorEmail.Email;
                        userrequest.Subject = "no-reply: New Business Travel Request for Your Information";
                        var usermailBody = @"<!DOCTYPE html>
                                     <html>
                                        <body>
                                            <p><strong>Dear Mr./ Ms. <b>" + requesterEmail + @"</b>,
                                                <br/><br/> We would like to inform you that the Event request you have submiited is successfully approved.
                                                <br/><br/> To Access the EventSystem please <a href="""">Click Here</a>
                                                <br/><br/> Thank you for your prompt attention to this matter.
                                                <br/><br/> <span style=""color:#7f0008;"">Note: This is a no-reply email. please do not reply to this email.</span>
                                                <br/><br/> Thanks, and Best Regards,
                                        </body>
                                    </html>";
                        userrequest.Body = usermailBody;
                        await _mailService.SendEmailAsync(userrequest);
                    
                }
                else
                {
                    var empIdFromEvent = await _dbContext.EventEntities.Where(b => b.EventId == eventId).Select(b => b.EmpId).FirstOrDefaultAsync();
                    var user = await _context.BueUsers.FirstOrDefaultAsync(u => u.EmpId == empIdFromEvent);
                    var SuperiorEmail = user.UserName.ToLower() + "@bue.edu.eg";
                    MailRequest request = new MailRequest();
                    request.ToEmail = SuperiorEmail;
                    request.Subject = "no-reply: New Business Travel Request for Your Action";
                    var mailBody = @"<!DOCTYPE html>
                                     <html>
                                        <body>
                                            <p><strong>Dear Mr./ Ms. <b>" + user.UserName + @"</b>,
                                                <br/><br/> We regret to inform you that your Event request has been rejected. Please review the details at your earliest convenience.
                                                <br/><br/> To Access the EventSystem please <a href="""">Click Here</a>
                                                <br/><br/> Thank you for your understanding.
                                                <br/><br/> <span style=""color:#7f0008;"">Note: This is a no-reply email. please do not reply to this email.</span>
                                                <br/><br/> Thanks, and Best Regards,
                                        </body>
                                    </html>";
                    request.Body = mailBody;
                    await _mailService.SendEmailAsync(request);

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Email Sender Failer");
            }
        }

        public async Task<bool> updateEventApprovals(eventApprovalUpdatesDto eventApprovalUpdatesDto, string userName, int userId)
        {
            try
            {
                var user = await _dbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.UserName == userName);
                if (user == null)
                {
                    return false;
                }

                var eventApproval = await _dbContext.EventApprovals.FirstOrDefaultAsync(u => u.EventId == eventApprovalUpdatesDto.eventId && u.EmpId == userId && u.ApprovalId == eventApprovalUpdatesDto.ApprovalId);

                if (eventApproval != null)
                {
                    eventApproval.Status = eventApprovalUpdatesDto.status;
                    eventApproval.UserTypeId = user.UserId;
                    eventApproval.CreatedAt = DateTime.Now;

                    var EventRequest = await _dbContext.EventEntities.Where(br => br.EventId == eventApproval.EventId).FirstOrDefaultAsync();
                    if (eventApproval.ApprovalId == 15 && eventApproval.Status == 1)
                    {
                        EventRequest.DecisionAt = DateTime.Now;
                    }

                    if (eventApproval.Status == 0)
                    {
                        EventRequest.DecisionAt = DateTime.Now;
                    }

                     _dbContext.EventApprovals.Update(eventApproval);
                     _dbContext.SaveChanges();
                    int empId = 0;
                    if (eventApproval.ApprovalId < 15)
                    {
                        int superiorLevelId = (int)eventApproval.ApprovalId + 1;
                        var businessApprovalSuperior = await _dbContext.EventApprovals.FirstOrDefaultAsync(u => u.EventId == eventApprovalUpdatesDto.eventId && u.ApprovalId== superiorLevelId);
                        if (businessApprovalSuperior != null)
                        {
                            empId = (int)businessApprovalSuperior.EmpId;
                        }
                        else
                        {
                            superiorLevelId++;
                            var businessApprovalNextSuperior = await _dbContext.EventApprovals.FirstOrDefaultAsync(u => u.EventId == eventApprovalUpdatesDto.eventId && u.ApprovalId == superiorLevelId);
                            empId = (int)businessApprovalNextSuperior.EmpId;
                        }
                    }
                    else
                    {
                        empId = 7987;
                    }
                    await SendEventAprovalEmail(empId, eventApprovalUpdatesDto.eventId, eventApprovalUpdatesDto.status);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<GetEventDTO>> GetEventRequestVCB(string usaerName)
        {
            try
            {
                var eventData = from req in _dbContext.EventEntities
                                join app in _dbContext.EventApprovals
                                on req.EventId equals app.EventId
                                where app.UserTypeId == 2 &&
                                      _dbContext.EventApprovals
                                                .Any(a => a.EventId == req.EventId &&
                                                          a.UserTypeId == 1 &&
                                                          a.Status == 1)
                                orderby (req.UpdateAt ?? req.ConfirmedAt ?? req.CreatedAt) descending
                                select new GetEventDTO
                                {
                                    EventId = req.EventId,
                                    EmpId = req.EmpId,
                                    EventTitle = req.EventTitle,
                                    ApprovingDeptName = req.ApprovingDeptName,
                                    EventStartDate = req.EventStartDate,
                                    EventEndDate = req.EventEndDate,
                                    CreatedAt = req.CreatedAt,
                                    UpdateAt = req.UpdateAt,
                                    Status = app.Status ?? 0,
                                    StatusName = (app.Status ?? 0) == 1
                                                 ? "Approved"
                                                 : (app.Status ?? 0) == 0
                                                   ? "Rejected"
                                                   : "Pending"
                                };

                return await eventData.ToListAsync();
            }
            catch (Exception ex)
            {
                throw; 
            }

        }

    }
}
