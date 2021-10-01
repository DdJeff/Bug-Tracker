using System.Collections.Generic;

namespace BugTracker.Models
{
    public class Employees
    {

        public Employees() { }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int SecurityLevel { get; set; }
        public IEnumerable<Employees> Emps { get; set; }

    }
}
