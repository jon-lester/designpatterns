using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory
{
    class Service : IService
    {
        // the connection factory is injected into the constructor
        private readonly IDatabaseConnectionFactory dbConnectionFactory;

        public Service(IDatabaseConnectionFactory dbConnectionFactory)
        {
            this.dbConnectionFactory = dbConnectionFactory;
        }

        public void DoWork()
        {
            // note that the connection oject is
            // whatever the factory provides
            IDatabaseConnection dbConnection = this.dbConnectionFactory.GetDatabaseConnection();

            // format the sql
            string sql = "UPDATE something";

            // execute it
            dbConnection.ExecuteSql(sql);
        }
    }
}
