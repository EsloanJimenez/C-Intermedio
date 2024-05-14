using PracticaDIP.Entities;

namespace PracticaDIP
{
    public class CustomerRepository
    {

        private List<Customers> customers;

        public CustomerRepository()
        {
            customers = new List<Customers>
            {
                new Customers {customerId = 1, name = "Enrique", phoneNumber = "849-451-6666", email = "EsloanJimenez@gmail.com" },
                new Customers {customerId = 2, name = "Yhennifer", phoneNumber = "849-229-0108", email = "Yhennifer01@gmail.com" },
                new Customers {customerId = 3, name = "Enyher", phoneNumber = "829-502-4684", email = "EnyherJimenez@gmail.com" },
            };
        }        
        public List<Customers> ViewInfo() => customers;
        
    }
}
