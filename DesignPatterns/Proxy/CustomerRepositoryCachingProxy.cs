using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    /// <summary>
    /// This class implements the proxy pattern - it adds functionality
    /// between the client and the proxied object without requiring
    /// structural change.
    /// 
    /// Note - the proxy pattern does not change any interface, but
    /// itself complies with an existing interface.
    /// </summary>
    class CustomerRepositoryCachingProxy : ICustomerRepository
    {
        private readonly ICustomerRepository _repository;

        // in this case, the proxy provides caching to mitigate
        // load on the database for frequent queries

        // a variation of the proxy pattern is the Virtual Proxy,
        // which goes a step further by avoiding any kind of initialisation
        // of an external resource until it's required

        Dictionary<long, Customer> _cache = new Dictionary<long, Customer>();

        public CustomerRepositoryCachingProxy(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Customer GetCustomerById(long customerId)
        {
            if (_cache.ContainsKey(customerId))
            {
                // (in this system, customer records never change, and memory is not a concern!)
                return _cache[customerId];
            }
            else
            {
                return _repository.GetCustomerById(customerId);
            }
        }
    }
}
