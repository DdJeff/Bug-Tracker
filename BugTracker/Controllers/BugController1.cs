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

        //get bug by Id
        public IActionResult ViewBug(string Id)
        {
            var singleBug = bug.GetBugById(Id);
            return View(singleBug);
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

        //update bug
        public IActionResult UpdateBug(string Id)
        {
            //get bug that you want to update by its Id
            Bug bugCompnets = bug.GetBugById(Id);
            return bugCompnets == null ? View(/*come back and make a view page for error*/"Product not found") : View(bugCompnets);
        }
        //add updated bug to the database
        public IActionResult UpdateBugDb(Bug updatedBug)
        {
            bug.UpdateBug(updatedBug);
            return RedirectToAction("ViewBug", new { Id = updatedBug.Id});
        }

        //removing a completed bug from the database
        public IActionResult DeleteBug(Bug deletedBug)
        {
           bug.DeleteBug(deletedBug);
           return RedirectToAction("Index");
        }
      
    }
}
