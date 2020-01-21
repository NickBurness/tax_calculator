using System;

namespace TaxCalculator
{
    public abstract class TaxCalculator
    {
        public int Year { get; }
        public bool SecondTaxPayment { get; set; }
        public abstract int CalculateTax(Vehicle vehicle);

        protected TaxCalculator() : this(DateTime.Now.Year, false)
        {

        }

        protected TaxCalculator(int year, bool secondTaxPayment)
        {
            Year = year;
            SecondTaxPayment = secondTaxPayment;
        }
    }
}
