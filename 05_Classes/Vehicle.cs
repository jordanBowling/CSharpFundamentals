using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Van, Spaceship, Plane}
    public class Vehicle
    {   
        // Hiddem implicit constructor
        // Needs to be manually written in order to be accessed
        // If there is any other constructor present
        public Vehicle() { }
        // Constructors go at the top
        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }
        
        
        
        
        
        
        
        // 1 Access modifier => Where can this be seen?
        // 2 Type => Type of the property as a held value
        // 3 Name => Name of the property method, Pascal case
        // 4 Getters and Setters
        // 1      2    3       4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
        public bool IsRunning { get; private set; }

        public void TurnOn()
        {
            IsRunning = true;

            Console.WriteLine("You turn on the vehicle");
        }

        public void TurnOff()
        {
            IsRunning = false;

            Console.WriteLine("You turn off the vehicle");
        }

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void TurnRight()
        {
            RightIndicator.FlashOn();
            LeftIndicator.FlashOff();
        }
        public void TurnLeft()
        {
            LeftIndicator.FlashOn();
            RightIndicator.FlashOff();
        }
        public void TurnOnHazards()
        {
            LeftIndicator.FlashOn();
            RightIndicator.FlashOn();
        }
        public void ClearIndicators()
        {
            LeftIndicator.FlashOff();
            RightIndicator.FlashOff();
        }

        
    }
        public class Indicator
    {
        // Create a class called Indicator that has a property called IsFlashing
        // IsFlashing should have a private set
        // The Indicator class also then needs the methods required to change the state of the IsFlashing Property

        public bool IsFlashing { get; private set; }

        public void FlashOn()
        {
            IsFlashing = true;

            Console.WriteLine("Your blinkers are on");
        }

        public void FlashOff()
        {
            IsFlashing = false;

            Console.WriteLine("Your blinkers are off");
        }



    }
}
