using LeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveApp.DAL
{
    public class LeaveRepository
    {
        private readonly LeaveDbContext _context = new LeaveDbContext();

        public List<LeaveRequest> GetLeaveRequestsByEmployee(int empId)
        {
            return _context.LeaveRequests.Where(l => l.EmployeeId == empId).ToList();
        }
        public List<LeaveRequest> GetSubordinateLeaveRequests()
        {
            return _context.LeaveRequests.Include("Employee").ToList();
        }
        public LeaveRequest GetLeaveById(int id)
        {
            return _context.LeaveRequests.Find(id);
        }
        public void AddLeave(LeaveRequest leave)
        {
            _context.LeaveRequests.Add(leave);
            _context.SaveChanges();
        }
        public void UpdateLeave(LeaveRequest leave)
        {
            _context.Entry(leave).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}