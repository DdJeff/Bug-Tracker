using System;
using System.Collections.Generic;
using BugTracker.Models;

namespace BugTracker
{
   public interface IPayRoll
    {
        public IEnumerable<Employees>GetAllEmployees();

        public Employees GetEmloyeeById(string Id);

    }
}
