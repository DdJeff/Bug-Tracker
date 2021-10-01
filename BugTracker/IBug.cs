using System;
using System.Collections.Generic;

using BugTracker.Models;

namespace BugTracker
{
   public interface IBug // it looks like you use an interface to remove abugutiy beween the controller and the model
    {
        public IEnumerable<Bug> GetBugs();

        public Bug GetBugById(string Id);

        public void UpdateBug(Bug bug);

        public void InsertBug(Bug insertBug);

        public Bug BugInstance();



        // come back and add a drop down.

    }
}
