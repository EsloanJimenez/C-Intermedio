using PracticaOCP.Interface;

namespace PracticaOCP.Clases
{
    public class TaxCalculatorForIn : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public decimal CalculateTaxAmount()
        {
            decimal taxAmount = 0;
            decimal taxableIncome = TotalIncome - TotalDeduction;

            if (TotalIncome > 0 && TotalIncome <= 250000)
                taxAmount = 0.3m;
            else if (TotalIncome >= 250001 && TotalIncome <= 500000)
                taxAmount = 0.5m;
            else if (TotalIncome >= 500001 && TotalIncome <= 1000000)
                taxAmount = 0.20m;
            else if (TotalIncome >= 1000001)


            taxableIncome *= taxAmount;

            return taxableIncome;
        }
    }
}
