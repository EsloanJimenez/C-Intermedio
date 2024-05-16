using PracticaOCP.Interface;

namespace PracticaOCP.Clases
{
    public class TaxCalculatorForUs : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }

        public decimal CalculateTaxAmount()
        {
            decimal taxAmount = 0;
            decimal taxableIncome = TotalIncome - TotalDeduction;

            if (TotalIncome > 0 && TotalIncome <= 11000)
                taxAmount = 0.10M;
            else if (TotalIncome >= 11001 && TotalIncome <= 44725)
                taxAmount = 0.12M;
            else if (TotalIncome >= 44726)
                taxAmount = 0.22M;


            taxableIncome *= taxAmount;

            return taxableIncome;
        }
    }
}
