using PracticaDIP;

CustomerService customerService = new CustomerService();

Console.WriteLine("LISTA DE LOS CLIENTES");

foreach(var lista in customerService.verTodo())
{
    Console.WriteLine($"""
                ID:                     {lista.customerId}
                NOMBRE:                 {lista.name}
                NUMERO CELULAR:         {lista.phoneNumber}
                CORREO ELECTRONICO:     {lista.email}
                """);
    Console.WriteLine("\n");
}