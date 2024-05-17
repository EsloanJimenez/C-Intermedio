using PracticaDIP.Entities;
using PracticaDIP.Interface;

namespace PracticaDIP
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customers> GetCustomers() => _customerRepository.GetCustomers();
    }
}
