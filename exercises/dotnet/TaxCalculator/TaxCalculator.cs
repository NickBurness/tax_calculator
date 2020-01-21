using System;

namespace TaxCalculator
{
    public abstract class TaxCalculator
    {
        public int Year { get; }
        public bool SecondTaxPayment { get; set; }
        public bool SecondTaxPaymentForExpensiveVehicle { get; set; }

        public abstract int CalculateTax(Vehicle vehicle);

        protected TaxCalculator() : this(DateTime.Now.Year, false, false)
        {

        }
        protected TaxCalculator(int year, bool secondTaxPayment) : this(year, secondTaxPayment, false)
        {

        }

        protected TaxCalculator(int year, bool secondTaxPayment, bool secondTaxPaymentForExpensiveVehicle)
        {
            Year = year;
            SecondTaxPayment = secondTaxPayment;
            SecondTaxPaymentForExpensiveVehicle = secondTaxPaymentForExpensiveVehicle;
        }
    }
}
