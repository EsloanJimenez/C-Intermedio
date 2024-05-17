using PracticaDIP.Entities;

namespace PracticaDIP.Interface
{
    public interface ICustomerRepository
    {
        List<Customers> GetCustomers();
    }
}
