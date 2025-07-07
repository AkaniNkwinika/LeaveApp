using LeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LeaveApp.Models;

namespace LeaveApp.DAL
{
    public class LeaveDbContext:DbContext
    {
        public LeaveDbContext() : base("DefaultConnection") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
    }
}