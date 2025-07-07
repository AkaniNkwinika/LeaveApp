using LeaveApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveApp.Controllers
{
    public class ManagerController : Controller
    {
        private LeaveDbContext db = new LeaveDbContext();

        public ActionResult PendingRequests()
        {
            var pending = db.LeaveRequests.Where(x => x.Status == "Pending").ToList();
            return View(pending);
        }
        public ActionResult Approve(int id)
        {
            var req = db.LeaveRequests.Find(id);
            req.Status = "Approved";
            db.SaveChanges();
            return RedirectToAction("PendingRequests");
        }
        public ActionResult Reject(int id)
        {
            var req = db.LeaveRequests.Find(id);
            req.Status = "Rejected";
            db.SaveChanges();
            return RedirectToAction("PendingRequests");
        }
    }
}