using PracticaOCP;

TaxCalculator calculando = new TaxCalculator();

Console.Write("Cual fue su ingreso en este mes: ");
decimal income = decimal.Parse(Console.ReadLine());

Console.Write("Cual fue su deduccion en este mes: ");
decimal deduction = decimal.Parse(Console.ReadLine());

Console.Write("De que pais eres: ");
string pais = Console.ReadLine().ToUpper();

Console.WriteLine($"Su total ingreso de este mes, con las deducciones y pago de impuestos es: {income - calculando.Calculate(income, deduction, pais)}");
