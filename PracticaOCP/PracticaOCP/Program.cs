using PracticaOCP;
using PracticaOCP.Clases;
using PracticaOCP.Entities;

ViewInfo viewInfo = new ViewInfo();

Console.Write("Cual fue su ingreso en este mes: \t");
decimal income = decimal.Parse(Console.ReadLine());

Console.Write("Cual fue su deduccion en este mes: \t");
decimal deduction = decimal.Parse(Console.ReadLine());

Console.Write("De que pais eres: \t\t\t");
string country = Console.ReadLine().ToUpper();

viewInfo.View(income, deduction, country);