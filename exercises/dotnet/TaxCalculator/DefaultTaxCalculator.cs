using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {   public DefaultTaxCalculator(int year, bool secondTaxPayment, bool secondTaxPaymentForExpensiveVehicle) : base(year, secondTaxPayment, secondTaxPaymentForExpensiveVehicle)
        {
            
        }

        public int CalculateTaxPetrol(Vehicle vehicle)
        {
            int tax = -1;

            if (vehicle.Co2Emissions <= 0)
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

            if (SecondTaxPayment == true)
            {
                tax = 140;
            }

            if (vehicle.ListPrice > 40000 && SecondTaxPaymentForExpensiveVehicle == true)
            {
                tax = 450;
            }

            return tax;
        }

        public int CalculateTaxDiesel(Vehicle vehicle)
        {
            int tax = -1;

            if (vehicle.Co2Emissions == 0)
            {
                tax = 0;
            }
            else if (vehicle.Co2Emissions <= 50)
            {
                tax = 25;
            }
            else if (vehicle.Co2Emissions <= 75)
            {
                tax = 105;
            }
            else if (vehicle.Co2Emissions <= 90)
            {
                tax = 125;
            }
            else if (vehicle.Co2Emissions <= 100)
            {
                tax = 145;
            }
            else if (vehicle.Co2Emissions <= 110)
            {
                tax = 165;
            }
            else if (vehicle.Co2Emissions <= 130)
            {
                tax = 205;
            }
            else if (vehicle.Co2Emissions <= 150)
            {
                tax = 515;
            }
            else if (vehicle.Co2Emissions <= 170)
            {
                tax = 830;
            }
            else if (vehicle.Co2Emissions <= 190)
            {
                tax = 1240;
            }
            else if (vehicle.Co2Emissions <= 225)
            {
                tax = 1760;
            }
            else
            {
                tax = 2070;
            }

            if (SecondTaxPayment == true)
            {
                tax = 140;
            }
            if (vehicle.ListPrice > 40000 && SecondTaxPaymentForExpensiveVehicle == true)
            {
                tax = 450;
            }

            return tax;

        }

        public int CalculateTaxAlternative(Vehicle vehicle)
        {
            int tax = -1;

            if (vehicle.Co2Emissions <= 50)
            {
                tax = 0;
            }
            else if (vehicle.Co2Emissions <= 75)
            {
                tax = 15;
            }
            else if (vehicle.Co2Emissions <= 90)
            {
                tax = 95;
            }
            else if (vehicle.Co2Emissions <= 100)
            {
                tax = 115;
            }
            else if (vehicle.Co2Emissions <= 110)
            {
                tax = 135;
            }
            else if (vehicle.Co2Emissions <= 130)
            {
                tax = 155;
            }
            else if (vehicle.Co2Emissions <= 150)
            {
                tax = 195;
            }
            else if (vehicle.Co2Emissions <= 170)
            {
                tax = 505;
            }
            else if (vehicle.Co2Emissions <= 190)
            {
                tax = 820;
            }
            else if (vehicle.Co2Emissions <= 225)
            {
                tax = 1230;
            }
            else if (vehicle.Co2Emissions <= 255)
            {
                tax = 1750;
            }
            else
            {
                tax = 2060;
            }

            if (SecondTaxPayment == true)
            {
                tax = 130;
            }
            if (vehicle.ListPrice > 40000 && SecondTaxPaymentForExpensiveVehicle == true)
            {
                tax = 440;
            }

            return tax;
        }

        public int CalculateTaxElectric(Vehicle vehicle)
        {
            int tax = -1;

            tax = 0;
            if (vehicle.ListPrice > 40000 && SecondTaxPaymentForExpensiveVehicle == true)
            {
                tax = 310;
            }

            return tax;
        }
        public override int CalculateTax(Vehicle vehicle)
        {

            int tax = -1;
      

            if (vehicle.FuelType == FuelType.Petrol)
            {
                tax = CalculateTaxPetrol(vehicle);
            } 
            else if (vehicle.FuelType == FuelType.Diesel)
            {
                tax = CalculateTaxDiesel(vehicle);
            }           
            else if (vehicle.FuelType == FuelType.AlternativeFuel)
            {
                tax = CalculateTaxAlternative(vehicle);
            }
            else if (vehicle.FuelType == FuelType.Electric)
            {
                tax = CalculateTaxElectric(vehicle);
            }
            
            return tax;
        }
    }
}
