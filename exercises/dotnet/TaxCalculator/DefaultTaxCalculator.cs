using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            int tax;

            if (vehicle.Co2Emissions == 0)
            {
                tax = 0;
            }
            else if (vehicle.Co2Emissions <= 50)
            {
                tax = 10;
            }
            else if (vehicle.Co2Emissions <= 75)
            {
                tax = 25;
            }
            else if (vehicle.Co2Emissions <= 90)
            {
                tax = 105;
            }
            else if (vehicle.Co2Emissions <= 100)
            {
                tax = 125;
            }
            else if (vehicle.Co2Emissions <= 110)
            {
                tax = 145;
            }
            else if (vehicle.Co2Emissions <= 130)
            {
                tax = 165;
            }
            else if (vehicle.Co2Emissions <= 150)
            {
                tax = 205;
            }
            else if (vehicle.Co2Emissions <= 170)
            {
                tax = 515;
            }
            else if (vehicle.Co2Emissions <= 190)
            {
                tax = 830;
            }
            else if (vehicle.Co2Emissions <= 225)
            {
                tax = 1240;
            }
            else if (vehicle.Co2Emissions <= 255)
            {
                tax = 1760;
            }
            else
            {
                tax = 2070;
            }
            return tax;
        }
    }
}
