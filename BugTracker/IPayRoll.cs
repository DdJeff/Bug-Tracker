using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker
{
   public interface IPayRoll
    {
        public IEnumerable<Employees>GetAllEmployees();

    }
}
