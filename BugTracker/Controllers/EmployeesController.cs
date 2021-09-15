﻿using Microsoft.AspNetCore.Mvc;
using BugTracker.Models;
using Microsoft.Extensions.Logging;

namespace BugTracker.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IPayRoll emp;
        public EmployeesController(IPayRoll emps)
        {
           emp = emps;

           
        }

        public IActionResult Index()
        {
            var employees = emp.GetAllEmployees();
            return View(employees);
        }
    }
}
