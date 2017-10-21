using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class Client
    {
        public void DoUsefulWork()
        {
            Singleton.Instance.UsefulMethod();
        }

        public async Task DoUsefulWorkAsync()
        {
            await Task.Run(() => ThreadSafeSingleton.Instance.UsefulMethod());
        }
    }
}
