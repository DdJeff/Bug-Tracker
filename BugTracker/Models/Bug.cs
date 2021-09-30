

using System;

namespace BugTracker.Models
{
    public class Bug
    {
        public Bug() { }
        public string Creator { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int Assigned { get; set; }

        internal object GetBugs()
        {
            throw new NotImplementedException();
        }
    }
}
