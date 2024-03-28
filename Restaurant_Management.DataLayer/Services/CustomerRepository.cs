using Restaurant_Management.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Restaurant_Management.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository

    {
        RestaurantDBEntities db = new RestaurantDBEntities();
        

        public bool DeleteCustomer(Customers customer)
        {

            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomersById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Customers GetCustomersById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool InsertCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public List<Customers> SelectAllCustomers()
        {
            return db.Customers.ToList();
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                 db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
