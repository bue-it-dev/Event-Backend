using Event.DTOs;
using Event.EventModel;
using Event.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Event.Repository.Implementations
{
    public class EventRepository : GenericRepository<EventEntity>, IEventRepository
    {
        private readonly EventContext _dbcontext;
        private readonly IUnitOfWork _unitOfWork;

        public EventRepository(EventContext dbcontext, IUnitOfWork unitOfWork)
            : base(dbcontext, unitOfWork)
        {
            _dbcontext = dbcontext;
            _unitOfWork = unitOfWork;
        }

        public async Task Submit(EventDTO eventData)
        {
            List<int> ApprovalAnnualLeaveList = new List<int>();
            List<int> ApprovalLevelSchema = new List<int>();

            var ApprovalDepartmentSelected = await _dbcontext.ApprovalSchemas.Where(e => e.DepName == eventData.DeptName).FirstOrDefaultAsync();
            int firstApprovalID = (int)ApprovalDepartmentSelected.FirstApprovalLevelId;
            int secondApprovalID = (int)ApprovalDepartmentSelected.SecondApprovalLevelId;
            ApprovalAnnualLeaveList.Add(firstApprovalID);
            ApprovalAnnualLeaveList.Add(secondApprovalID);
            int firstempIDroleId = (int)await _dbcontext.Users.Where(e => e.EmpId == firstApprovalID).Select(e => e.UserTypeId).FirstOrDefaultAsync();
            int secondempIDroleId = (int)await _dbcontext.Users.Where(e => e.EmpId == secondApprovalID).Select(e => e.UserTypeId).FirstOrDefaultAsync();
         
        }

    }
}
