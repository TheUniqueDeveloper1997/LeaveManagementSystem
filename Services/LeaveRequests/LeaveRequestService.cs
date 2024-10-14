using LeaveManagementSystem.Web.Services.LeaveRequests;

namespace LeaveManagementSystem.Web.Models.LeaveRequests
{
    public class LeaveRequestService : ILeaveRequestService
    {
        public Task CancelLeaveRequest(int leaveRequestId)
        {
            throw new NotImplementedException();
        }

        public Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveRequestListVM> GetAllLeaveRequests()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeLeaveRequestListVM> GetEmployeeLeaveRequest()
        {
            throw new NotImplementedException();
        }

        public Task ReviewLeaveRequest(ReviewLeaveRequestVM model)
        {
            throw new NotImplementedException();
        }
    }
}
