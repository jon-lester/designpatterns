using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory
{
    class MySqlDatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        public IDatabaseConnection GetDatabaseConnection()
        {
            return new MySqlDatabaseConnection();
        }
    }
}
