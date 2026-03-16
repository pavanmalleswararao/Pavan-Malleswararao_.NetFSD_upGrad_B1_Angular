using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment_Vehicle
{
    public class Vehicle
    {
        public string VehicleNumber {  get; set; }
        public string Brand { get; set; }
        public void StartVehicle()
        {
            Console.WriteLine("Vehicle Started...");
        }
    }
    public class Car : Vehicle
    {
        public string FuelType { get; set; }
        public void ShowCarDetails()
        {
            Console.WriteLine("Car Number: " + VehicleNumber);
            Console.WriteLine("Car Brand: "+Brand);
            Console.WriteLine("Fuel Type: "+FuelType);
        }
    }

    public class Bike : Vehicle
    {
        public void ShowBikeDetails()
        {
            Console.WriteLine("Bike Number: " + VehicleNumber);
            Console.WriteLine("Bike Brand: "+Brand);
        }
    }
    public sealed class ElectricCar : Car
    {
        public void ShowEletricCarInfo()
        {
            Console.WriteLine("This is Eletric Car");
        }
    }
}
