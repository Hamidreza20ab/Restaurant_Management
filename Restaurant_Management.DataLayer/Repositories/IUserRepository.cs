using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DataLayer.Models;


namespace Restaurant_Management.DataLayer.Repositories
{
    public interface IUserRepository
    {
        
        
        List<Users> SelectAllUsers();

      
        Users GetUserById(int userId);

     
        bool InsertUser(Users user);

       
        bool UpdateUser(Users user);

       
        bool DeleteUser(Users user);

       
        bool DeleteUser(int userId);

        
        void Save();
    }
}
