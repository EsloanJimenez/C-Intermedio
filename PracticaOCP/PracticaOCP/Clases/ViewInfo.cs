using PracticaOCP.Entities;
using static System.Console;

namespace PracticaOCP.Clases
{
    public class ViewInfo
    {
        public void View(decimal income, decimal deduction, string country) {
            Details details = new Details();
            Selecction op = new Selecction();

            details.TotalIncome = income;
            details.TotalDeduction = deduction;
            details.Country = country;

            WriteLine($"\n\nIngresos del mes: \t\t\t {income}");
            WriteLine($"Deducion del mes: \t\t\t {deduction}");
            WriteLine($"Pais de origen: \t\t\t {country}");
            WriteLine($"Ingresos con la deduccion: \t\t {income - deduction}");
            WriteLine($"Impuestos a pagar: \t\t\t {op.Option(details)}");
        }
    }
}
