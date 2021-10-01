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
        //creating the new bug
        public IActionResult InsertBug()
        {
            var newBug = bug.BugInstance();

            return View(newBug);
        }
        //Inserting the new bug into database
        public IActionResult InsertBugDb(Bug bugToInsert)
        {
            bug.InsertBug(bugToInsert);
            return RedirectToAction("Index");
        }
      
    }
}
