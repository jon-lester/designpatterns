namespace DesignPatterns.Factory.Interfaces
{
    /// <summary>
    /// All database connections implement this interface.
    /// </summary>
    interface IDatabaseConnection
    {
        void ExecuteSql(string sql);
    }
}
