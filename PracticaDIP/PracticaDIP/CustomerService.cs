using PracticaDIP.Entities;

namespace PracticaDIP
{
    public class CustomerService
    {
        private CustomerRepository repository;

        public CustomerService()
        {
            repository = new CustomerRepository();
        }

        public List<Customers> verTodo() => repository.ViewInfo();
    }
}
