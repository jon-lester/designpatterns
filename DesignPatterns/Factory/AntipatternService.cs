using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory
{
    class AntipatternService : IService
    {
        public void DoWork()
        {
            AccessDatabaseConnection dbConnection = new AccessDatabaseConnection();

            // format the sql
            var sql = "UPDATE something";

            // execute it
            dbConnection.ExecuteSql(sql);
        }
    }
}
