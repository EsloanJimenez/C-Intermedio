
using PracticaOCP;

TaxCalculator calculando = new TaxCalculator();

Console.Write("Cual fue su ingreso en este mes: ");
double income = double.Parse(Console.ReadLine());

Console.Write("Cual fue su deduccion en este mes: ");
double deduction = double.Parse(Console.ReadLine());

Console.Write("De que pais eres: ");
string pais = Console.ReadLine();

Console.WriteLine(calculando.Calculate(income, deduction, pais));
