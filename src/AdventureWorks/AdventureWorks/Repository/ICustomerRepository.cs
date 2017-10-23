using AdventureWorks.Models;
using System.Collections.Generic;

namespace AdventureWorks.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();

        Customer GetCustomer(int customerId);
 
    }
}