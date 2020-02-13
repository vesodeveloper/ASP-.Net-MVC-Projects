using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using SimpTest.Entities;

namespace SimpTest.Repo
{
    public class RegRepo
    {
        private RegDB regDB = null;
        public RegRepo()
        {
             regDB = new RegDB();
        }
        public List<RUser> UList()
        {
            return regDB.RUsers.ToList();
        }
        public void AddRUser(RUser user) {
            regDB.RUsers.Add(user);
            regDB.SaveChanges();
          }
        public void UpdateRUser(RUser user)
        {
            DbEntityEntry entity = regDB.Entry(user);
            entity.State = System.Data.Entity.EntityState.Modified;
            regDB.SaveChanges();
        }
        public RUser GetById(int id)
        {
            return regDB.RUsers
                   .Where(i => i.Id == id)
                   .FirstOrDefault();
        }
        public RUser GetFirstorDefault(Exception<Func<RUser,bool>>filter)
        
        {
            return regDB.RUsers
                .Where(filter)
                .FirstorDefault();
        }
        public void DeleteRUser(int id)
        {
            RUser item = GetById(id);
            if (item != null)
            {
                regDB.RUsers.Remove(item);
                regDB.SaveChanges();
            }
        }

    }
}
