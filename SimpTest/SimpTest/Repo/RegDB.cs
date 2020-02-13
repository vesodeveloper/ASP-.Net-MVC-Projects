using System;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Web.Configuration;
using SimpTest.Entities;

namespace SimpTest.Repo
{
    public class RegDB : DbContext
    {
        public DbSet<RUser>RUsers{ get; set; }
        public RegDB()
            :base("Server=localhost;Database=id11874842_testdb;Uid=id11874842_vesotest;Pwd=vesotestpass;")
        {
            RUsers = this.Set<RUser>();
        }
    }
}
