using LeaveApp.DAL;
using LeaveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly LeaveRepository _repo = new LeaveRepository();
        public ActionResult MyLeaves()
        {
            int employeeId = 1; 
            var leaves = _repo.GetLeaveRequestsByEmployee(employeeId);
            return View(leaves);
        }
        public ActionResult ApplyLeave()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ApplyLeave(LeaveRequest model)
        {
            model.EmployeeId = 1;
            model.Status = "Pending";
            _repo.AddLeave(model);
            return RedirectToAction("MyLeaves");
        }
    }
}