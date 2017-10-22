using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Subsystem
{
    class OrderProcessor
    {
        internal long ConfirmOrder(string orderValidationCode)
        {
            throw new NotImplementedException();
        }

        internal bool ValidateOrder(long customerId, long stockItemId, out string orderValidationCode)
        {
            throw new NotImplementedException();
        }
    }
}
