using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    /// <summary>
    /// A singleton class guarantees that there is one and only one
    /// instance of the class present in the application.
    /// </summary>
    class Singleton
    {
        // the one-and-only instance of the the Singleton class
        private static Singleton _instance;

        /// <summary>
        /// Retrieve the one and only instance of Singleton.
        /// 
        /// The getter arranges for the single class variable instance
        /// to be constructed iff it hasn't been already. This is the
        /// classic means of implementing the pattern, however is
        /// potentially not thread-safe.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    // what if two threads enter this
                    // conditional at the same time?
                    _instance = new Singleton();
                }

                // return the instance, which is now guaranteed to exist
                return _instance;
            }
        }

        /// <summary>
        /// The instance methods of Singleton are implemented
        /// here and below.
        /// </summary>
        public void UsefulMethod()
        {

        }
    }
}
