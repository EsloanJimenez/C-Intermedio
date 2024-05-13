namespace PracticaOCP
{
    public class TaxCalculator : Calculadora
    {
        public override decimal Calculate(decimal income, decimal deduction, string country)
        {
            decimal taxAmount = 0;
            decimal taxableIncome = income - deduction;

            switch (country)
            {
                case "INDIANA":
                    if (income <= 250000)
                    {
                        taxAmount = 0.3m;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 250001 && income <= 500000)
                    {
                        taxAmount = 0.5m;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 500001 && income <= 1000000)
                    {
                        taxAmount = 0.20m;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 1000001)
                    {
                        taxAmount = 0.30m;
                        taxableIncome *= taxAmount;
                    }
                        break;
                case "USA":
                    if (income <= 11000) {
                        taxAmount = 0.10M;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 11001 && income <= 44725) {
                        taxAmount = 0.12M;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 44726) {
                        taxAmount = 0.22M;
                        taxableIncome *= taxAmount;
                    }
                        break;
                case "UK":
                    if (income <= 12570)
                    {
                        taxAmount = 0;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 12501 && income <= 50270)
                    {
                        taxAmount = 0.20m;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 50271 && income <= 150000)
                    {
                        taxAmount = 0.40m;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 150001)
                    {
                        taxAmount = 0.45m;
                        taxableIncome *= taxAmount;
                    }
                    break;
                case "RD":
                    if (income <= 416220)
                    {
                        taxAmount = 0;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 416221 && income <= 624329)
                    {
                        taxAmount = 0.15m;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 624330 && income <= 867123)
                    {
                        taxAmount = 0.20m;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 867124)
                    {
                        taxAmount = 0.25m;
                        taxableIncome *= taxAmount;
                    }
                        break;
                default:
                    Console.WriteLine("El pais seleccionado no esta contemplado");
                    break;
            }
            return taxableIncome;
        }
    }
}
