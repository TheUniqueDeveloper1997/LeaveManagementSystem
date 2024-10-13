using AutoMapper;
using LeaveManagementSystem.Web.Models.LeaveAllocations;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;

namespace LeaveManagementSystem.Web.Services.LeaveAllocations;

public class LeaveAllocationsService(ApplicationDbContext _context, IHttpContextAccessor _httpContextAccessor, 
    UserManager<ApplicationUser> _userManager, IMapper _mapper) : ILeaveAllocationsService
{
    public async Task AllocateLeave(string employeeId)
    {
        var leaveTypes = await _context.LeaveTypes.ToListAsync();
        var currentDate = DateTime.Now;
        var period = await _context.Periods.SingleAsync(q=>q.EndDate.Year == currentDate.Year);
        var monthsRemaining = period.EndDate.Month - currentDate.Month;
        foreach (var leaveType in leaveTypes) {
            var accuralRate = Decimal.Divide(leaveType.NumberOfDays, 12);
            var leaveAllocation = new LeaveAllocation
            {
                EmployeeId = employeeId,
                LeaveTypeId = leaveType.Id,
                PeriodId = period.Id,
                Days = (int)Math.Ceiling(accuralRate / monthsRemaining)
            };
            _context.Add(leaveAllocation);
        }
        await _context.SaveChangesAsync();
    }

    public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string? userId)
    {
        var user = string.IsNullOrEmpty(userId)
            ? await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User)
            : await _userManager.FindByIdAsync(userId); 

        var allocations = await GetAllocations(user.Id);
        var allocationVMList = _mapper.Map<List<LeaveAllocation>, List<LeaveAllocationVM>>(allocations);
        var employeeVM = new EmployeeAllocationVM
        {
            DateOfBirth = user.DateOfBirth,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Id = user.Id,
            LeaveAllocations = allocationVMList
        };
        return employeeVM;
    }

    public async Task<List<EmployeeListVM>> GetEmployees()
    {
        var users = await _userManager.GetUsersInRoleAsync(Roles.Employee);
        var employees = _mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(users.ToList());
        return employees;
    }
    private async Task<List<LeaveAllocation>> GetAllocations(string? userId)
    {
        var currentDate = DateTime.Now;
        var leaveAllocations = await _context.LeaveAllocations
            .Include(q => q.LeaveType)
            .Include(q => q.Period)
            .Where(q => q.EmployeeId == userId && q.Period.EndDate.Year == currentDate.Year)
            .ToListAsync();
        return leaveAllocations;
    }
}
