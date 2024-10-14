using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveRequests;

namespace LeaveManagementSystem.Web.Services.LeaveRequests
{
    public interface ILeaveRequestService
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestListVM> GetEmployeeLeaveRequest();
        Task<LeaveRequestListVM> GetAllLeaveRequests();
        Task CancelLeaveRequest(int leaveRequestId);
        Task ReviewLeaveRequest(ReviewLeaveRequestVM model);
    }
}