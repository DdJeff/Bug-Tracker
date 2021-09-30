using Microsoft.AspNetCore.Mvc;
using BugTracker.Models;


namespace BugTracker.Controllers
{
    public class BugController1 : Controller
    {
        private readonly IBug bug;
        public BugController1(IBug bugs)
        {
            bug = bugs;
        }
        public IActionResult Index()
        {
            var allBugs = bug.GetBugs();
            return View(allBugs);
        }

        public IActionResult InsertBug()
        {
            var newBug = bug.AssignCategory();
            return View(newBug);
        }

        public IActionResult InsertBugDb(Bug bugToInsert)
        {
            bug.InsertBug(bugToInsert);
            return RedirectToAction("Index");
        }
      
    }
}
