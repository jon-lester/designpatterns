using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory
{
    class AccessDatabaseConnection : IDatabaseConnection
    {
        public void ExecuteSql(string sql)
        {
            // execute the SQL against an Access database
        }
    }
}
