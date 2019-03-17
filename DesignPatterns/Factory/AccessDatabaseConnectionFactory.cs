using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory
{
    class AccessDatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        public IDatabaseConnection GetDatabaseConnection()
        {
            return new AccessDatabaseConnection();
        }
    }
}
