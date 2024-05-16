using PracticaOCP.Interface;

namespace PracticaOCP.Clases
{
    public class TaxCalculatorForRd : ICountryTaxCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }
        public decimal CalculateTaxAmount()
        {
            decimal taxAmount = 0;
            decimal taxableIncome = TotalIncome - TotalDeduction;

            if (TotalIncome > 0 && TotalIncome <= 416220) 
                taxAmount = 0;
            else if (TotalIncome >= 416221 && TotalIncome <= 624329) 
                taxAmount = 0.15m;
            else if (TotalIncome >= 624330 && TotalIncome <= 867123) 
                taxAmount = 0.20m;
            else if (TotalIncome >= 867124) 
                taxAmount = 0.25m;


            taxableIncome *= taxAmount;

            return taxableIncome;
        }
    }
}
