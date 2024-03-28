using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DataLayer.Repositories
{
     public interface ICustomerRepository
    {
        List<Customers> SelectAllCustomers();
        Customers GetCustomersById(int customerId);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);

        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
        void Save();

    }
}
