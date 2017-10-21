using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    /// <summary>
    /// This version of singleton is thread-safe.
    /// </summary>
    class ThreadSafeSingleton
    {
        // while it would be possible to attempt to use locking within the Instance
        // property to initialise the _instance class variable in a thread-safe way,
        // using a static initialiser guarantees that _instance is initialised
        // only once before it's accessed. (Static initialisation is done before
        // the static constructor is run, which itself is guaranteed to run only once
        // per app domain.)

        private static readonly ThreadSafeSingleton _instance = new ThreadSafeSingleton();

        /// <summary>
        /// Retrieve the one and only instance of ThreadSafeSingleton. This
        /// property is thread-safe.
        /// </summary>
        public static ThreadSafeSingleton Instance => _instance;

        /// <summary>
        /// The instance methods of Singleton are implemented
        /// here and below.
        /// </summary>
        public void UsefulMethod()
        {

        }
    }
}
