using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }   
        public string EmployeeNumber { get; set; } 
        public string CellphoneNumber { get; set; } 
        public bool IsManager { get; set; }

        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }
    }
}