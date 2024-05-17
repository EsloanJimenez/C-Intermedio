using PracticaDIP;

CustomerRepository customerRepository = new CustomerRepository();
CustomerService customerService = new CustomerService(customerRepository);

Console.WriteLine("LISTA DE LOS CLIENTES");

foreach(var lista in customerService.GetCustomers())
{
    Console.WriteLine($"""
                ID:                     {lista.CustomerId}
                NOMBRE:                 {lista.Name}
                NUMERO CELULAR:         {lista.PhoneNumber}
                CORREO ELECTRONICO:     {lista.Email}
                """);
    Console.WriteLine("\n");
}