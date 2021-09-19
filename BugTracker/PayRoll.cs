using Dapper;
using System.Collections.Generic;
using System.Data;
using BugTracker.Models;

namespace BugTracker
{
    public class PayRoll : IPayRoll
    {
        private readonly IDbConnection dbConnection;

        public PayRoll(IDbConnection db)
        {
            dbConnection = db;
        }
        public IEnumerable<Employees> GetAllEmployees()
        {
            return dbConnection.Query<Employees>("SELECT * FROM employees;");
        }

        public Employees GetEmloyeeById(string Id)
        {
            return dbConnection.QuerySingle<Employees>("SELECT * FROM employees WHERE Id = @id", new { id = Id});
        }
    }
}
