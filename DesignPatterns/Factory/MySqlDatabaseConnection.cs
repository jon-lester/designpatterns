using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory
{
    class MySqlDatabaseConnection : IDatabaseConnection
    {
        public void ExecuteSql(string sql)
        {
            // execute the SQL against a MySQL database
        }
    }
}
