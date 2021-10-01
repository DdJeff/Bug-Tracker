using BugTracker.Models;
using System;
using System.Collections.Generic;
using Dapper;
using System.Data;

namespace BugTracker
{
    public class BugDb : IBug
    { 
        private readonly IDbConnection dbCon;

        public BugDb (IDbConnection db)
        {
            dbCon = db;
        }
         public IEnumerable<Bug> GetBugs()
        {
           
            return dbCon.Query<Bug>("SELECT * FROM bugs;");

        }
        public Bug GetBugById(string Id)
        {
            throw new NotImplementedException();
        }

       
        public void InsertBug(Bug insertBug)
        { 
            dbCon.Execute("INSERT INTO bugs (Creator, Id, Title, Summary, Assigned) VALUES (@Creator, @Id, @Title, @Summary, @Assigned); ", new { Creator = insertBug.Creator, Id = insertBug.Id, Title = insertBug.Title, Summary = insertBug.Summary, Assigned = insertBug.Assigned }); 
        }

        public Bug BugInstance()
        {
            var bug = new Bug();
            return bug;
        }

        public void UpdateBug(Bug bug)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employees> GetEmployees()
        {
            return dbCon.Query<Employees>("SELECT * FROM categories;");
        }
    }
}
