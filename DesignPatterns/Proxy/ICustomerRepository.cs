namespace DesignPatterns.Proxy
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(long customerId);
    }
}