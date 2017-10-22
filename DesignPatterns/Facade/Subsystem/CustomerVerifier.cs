using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Subsystem
{
    class CustomerVerifier
    {
        public bool VerifyCustomer(long customerId, DateTime time)
        {
            return true;
        }
    }
}
