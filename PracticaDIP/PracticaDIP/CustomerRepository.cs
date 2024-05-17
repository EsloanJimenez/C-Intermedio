using PracticaDIP.Entities;
using PracticaDIP.Interface;

namespace PracticaDIP
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly List<Customers> customers;

        public CustomerRepository()
        {
            customers = new List<Customers>
            {
                    new Customers {CustomerId = 1, Name = "Enrique", PhoneNumber = "849-451-6666", Email = "EsloanJimenez@gmail.com" },
                    new Customers {CustomerId = 2, Name = "Yhennifer", PhoneNumber = "849-229-0108", Email = "Yhennifer01@gmail.com" },
                    new Customers {CustomerId = 3, Name = "Enyher", PhoneNumber = "829-502-4684", Email = "EnyherJimenez@gmail.com" }
            };
        }        
        
        public List<Customers> GetCustomers() => customers;
    }
}
