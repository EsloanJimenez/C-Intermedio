using PracticaOCP.Entities;
using PracticaOCP.Interface;

namespace PracticaOCP.Clases
{
    public class Selecction
    {
        public object Option(Details obj) {
            ICountryTaxCalculator c = null;

            switch(obj.Country)
            {
                case "USA":
                    c = new TaxCalculatorForUs();
                    break;
                case "UK":
                    c = new TaxCalculatorForUk();
                    break;
                case "IN":
                    c = new TaxCalculatorForIn();
                    break;
                case "RD":
                    c = new TaxCalculatorForRd();
                    break;
                default:
                    Console.Write("La opcion seleccionada no esta contemplada");
                    break;
            }

            c.TotalIncome = obj.TotalIncome;
            c.TotalDeduction  = obj.TotalDeduction;
            TaxCalculator calculando = new TaxCalculator();


            return calculando.Calculate(c);
        }
    }
}
