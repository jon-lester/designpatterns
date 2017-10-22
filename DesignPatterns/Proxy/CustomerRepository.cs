using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    /// <summary>
    /// This is the (an) implementation of CustomerRepository,
    /// directly accessing the database to return the customer
    /// data.
    /// </summary>
    class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerById(long customerId)
        {
            // db code
            return new object() as Customer;
        }
    }
}
