using PracticaOCP.Interface;

namespace PracticaOCP.Clases
{
    public class TaxCalculatorForUk : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public decimal CalculateTaxAmount()
        {
            decimal taxAmount = 0;
            decimal taxableIncome = TotalIncome - TotalDeduction;

            if (TotalIncome > 0 && TotalIncome <= 12570)
                taxAmount = 0;
            else if (TotalIncome >= 12501 && TotalIncome <= 50270)
                taxAmount = 0.20m;
            else if (TotalIncome >= 50271 && TotalIncome <= 150000)
                taxAmount = 0.40m;
            else if (TotalIncome >= 150001)
                taxAmount = 0.45m;


            taxableIncome *= taxAmount;

            return taxableIncome;
        }
    }
}
