using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// The Factory pattern allows a new instance of an object to be created on-demand.
    /// 
    /// It can be used to decouple an object from the implementation of a collaborating
    /// class (provided that the object implements an interface).
    /// </summary>
    class Client
    {
        // This method asks a service to do some work with a database.

        public void Run()
        {
            // With this implementation, the service is hard-coded to use
            // the Access database connection:

            IService service = new AntipatternService();
            service.DoWork();

            // The improved service uses a factory to obtain a connection. The behaviour
            // of the following two lines is the same as above - an Access database is used.

            IService service2 = new Service(new AccessDatabaseConnectionFactory());
            service2.DoWork();

            // However - we can now use the same service implementation to execute
            // with a MySQL database, by passing in a different connection factory.

            // (for the purpose of this example I'm pretending that SQL syntax is the
            // same for both databases!)

            IService service3 = new Service(new MySqlDatabaseConnectionFactory());
            service3.DoWork();

            // Note that the advantage of passing in a factory as opposed to passing
            // in a connection itself is that the service can create as many connections
            // as it needs as often as it needs - ie. each service method could be
            // wrapped in a "create" .. "dispose" pattern in this case.
        }
    }
}
