namespace DesignPatterns.Factory.Interfaces
{
    interface IDatabaseConnectionFactory
    {
        IDatabaseConnection GetDatabaseConnection();
    }
}
