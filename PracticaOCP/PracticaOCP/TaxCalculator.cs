namespace PracticaOCP
{
    public class TaxCalculator
    {
        public double Calculate(double income, double deduction, string country)
        {
            double taxAmount = 0;
            double taxableIncome = income - deduction;

            switch (country)
            {
                case "India":
                    if (income <= 250000)
                        taxAmount = 3;
                    else if (income >= 250001 && income <= 500000)
                        taxAmount = 5;
                    else if (income >= 500001 && income <= 1000000)
                        taxAmount = 20;
                    else if (income >= 1000001)
                        taxAmount = 30;

                    break;
                case "USA":
                    if (income <= 11000)
                        taxAmount = 10;
                    else if (income >= 11001 && income <= 44725)
                        taxAmount = 12;
                    else if (income >= 44726)
                        taxAmount = 22;

                    break;
                case "UK":
                    if (income <= 12570)
                        taxAmount = 0;
                    else if (income >= 12501 && income <= 50270)
                        taxAmount = 20;
                    else if (income >= 50271 && income <= 150000)
                        taxAmount = 40;
                    else if (income >= 150001)
                        taxAmount = 45;

                    break;
                case "RD":
                    if (income <= 416220)
                        taxAmount = 0;
                    else if (income >= 416221 && income <= 624329) { 
                        taxAmount = 0.15;
                        taxableIncome *= taxAmount;
                    }
                    else if (income >= 624330 && income <= 867123)
                        taxAmount = 20;
                    else if (income >= 867124)
                        taxAmount = 25;

                    break;
                default:
                    Console.WriteLine("El pais seleccionado no esta contemplado");
                    break;
            }

            return taxableIncome;
        }
    }
}
