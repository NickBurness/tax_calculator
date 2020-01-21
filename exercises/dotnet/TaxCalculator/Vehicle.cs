using System;

namespace TaxCalculator
{
    public class Vehicle
    {
        public int Co2Emissions { get; }
        public FuelType FuelType { get; }
        public DateTime DateOfFirstRegistration { get; }
        public int ListPrice { get; }

        public bool Rde2Compliant { get; }

        public Vehicle(int co2Emissions, FuelType fuelType, DateTime dateOfFirstRegistration, int listPrice, bool rde2Compliant = false)
        {
            Co2Emissions = co2Emissions;
            FuelType = fuelType;
            DateOfFirstRegistration = dateOfFirstRegistration;
            ListPrice = listPrice;
            Rde2Compliant = rde2Compliant;
        }
    }
}
