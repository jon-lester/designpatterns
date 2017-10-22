using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// The client class wishes to be able to make orders without
    /// being tightly bound to the inner workings of the order system,
    /// therefore a facade over the order system is needed to
    /// provide a simplified means of access.
    /// </summary>
    class Client
    {
        public void MakeOrder(long customerId, long stockItemId)
        {
            var orderSystem = new OrderingSystemFacade();
            if (orderSystem.MakeOrder(customerId, stockItemId))
            {
                // act on success
            }
            else
            {
                // act on failure
            }
        }
    }
}
