﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveApp.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string LeaveType { get; set; } 

        public string Status { get; set; }    

        public virtual Employee Employee { get; set; }  
    }
}