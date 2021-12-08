using System;
using System.Collections.Generic;

using BugTracker.Models;

namespace BugTracker
{
   public interface IBug 
    {
        public IEnumerable<Bug> GetBugs();

        public Bug GetBugById(string Id);

        public void UpdateBug(Bug bug);

        public void InsertBug(Bug insertBug);

        public void DeleteBug(Bug deletedBug);

        public Bug BugInstance();



       

    }
}
