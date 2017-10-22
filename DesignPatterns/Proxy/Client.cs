using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    /// <summary>
    /// The proxy client wishes to use a database repository
    /// to access customer data, and is designed to use that
    /// repository's interface.
    /// </summary>
    class Client
    {
        // dependency injection would bind ICustomerRepository to..
        // CustomerRepositoryCachingProxy in the context of Client
        // CustomerRepository in the context of CustomerRepositoryCachingProxy

        private ICustomerRepository _repo;

        public Client(ICustomerRepository repo)
        {
            // the client doesn't need to know whether
            // it's using the repository or a proxy
            _repo = repo;
        }

        public void PerformUsefulTask(long customerId)
        {
            _repo.GetCustomerById(customerId);
        }
    }
}
