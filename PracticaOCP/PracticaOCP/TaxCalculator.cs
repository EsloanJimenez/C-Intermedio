using PracticaOCP.Interface;

namespace PracticaOCP
{
    public class TaxCalculator
    {
        public decimal Calculate(ICountryTaxCalculator obj)
        {
            return obj.CalculateTaxAmount();
        }
    }
}
