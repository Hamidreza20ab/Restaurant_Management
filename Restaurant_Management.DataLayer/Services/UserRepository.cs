using Restaurant_Management.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using Restaurant_Management.DataLayer.Models;


namespace Restaurant_Management.DataLayer.Services
{
    internal class UserRepository : IUserRepository
    {
        RS_Model db;
        public bool DeleteUser(Users user)
        {
            try
            {
                db.Entry(user).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(int userId)
        {
            try
            {
                var user = GetUserById(userId);
                DeleteUser(user);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public Users GetUserById(int userId)
        {
            return db.Users.Find(userId);
        }

        public bool InsertUser(Users user)
        {
            try
            {
                db.Users.Add(user);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public void Save()
        {
            db.SaveChanges();
        }

        public List<Users> SelectAllUsers()
        {
            return db.Users.ToList();
        }

        public bool UpdateUser(Users user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
