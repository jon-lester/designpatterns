using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Facade.Subsystem;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// This class implements the facade pattern to conceal the complexity
    /// of the ordering subsystem from client code.
    /// 
    /// Note - the facade pattern implements a new interface to reduce complexity.
    /// </summary>
    class OrderingSystemFacade
    {
        /// <summary>
        /// Make an order; return true if successful, otherwise return false.
        /// </summary>
        /// <param name="customerId">The ID of the customer.</param>
        /// <param name="stockItemId">The ID of the stock item.</param>
        /// <returns>True if the order was made.</returns>
        public bool MakeOrder(long customerId, long stockItemId)
        {
            // this example code not intended to represent a well-designed order system ;)
            using (var audit = new AuditlogSystem())
            {
                var verifier = new CustomerVerifier();
                var orderProcesser = new OrderProcessor();
                var stockChecker = new StockChecker();

                if (verifier.VerifyCustomer(customerId, DateTime.UtcNow))
                {
                    audit.LogStockInterest(customerId, stockItemId);
                    if (stockChecker.CheckStockAmount(stockItemId) > 0)
                    {
                        string orderValidationCode;
                        bool orderValidationSuccess = orderProcesser.ValidateOrder(customerId, stockItemId, out orderValidationCode);

                        if (orderValidationSuccess)
                        {
                            long orderId = orderProcesser.ConfirmOrder(orderValidationCode);
                            audit.LogOrderMade(orderId, orderValidationCode);

                            return true;
                        }
                        else
                        {
                            audit.LogOrderFailed(orderValidationCode);
                        }

                        audit.LogCustomerInteraction(customerId);
                    }
                }
                return false;
            }
        }
    }
}