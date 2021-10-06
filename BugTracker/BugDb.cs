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
            return dbCon.QuerySingle<Bug>("SELECT * FROM bugs WHERE Id = @Id", new { Id = Id });
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
           dbCon.Execute("UPDATE bugs SET Creator = @Creator, Summary = @Summary, Assigned = @Assigned WHERE Id = @Id",
           new { Creator = bug.Creator, Summary = bug.Summary, Assigned = bug.Assigned, Id = bug.Id });
        }

        public void DeleteBug(Bug bug)
        {
            dbCon.Execute("DELETE FROM bugs WHERE Id = @Id", new {Id = bug.Id});
        }
        public IEnumerable<Employees> GetEmployees()
        {
            return dbCon.Query<Employees>("SELECT * FROM employees;");
        }  
        
       

       
    }
}
