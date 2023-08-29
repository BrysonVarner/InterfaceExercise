using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

                //Create 2 Interfaces called IVehicle & ICompany

                //Create 3 classes called Car , Truck , & SUV
            
                //Now, create objects of your 3 classes and give their members values;
                //Creatively display and organize their values
            */
            var newCar = new Car();
            newCar.LicensePlateNum = "437-JRT";
            newCar.Year = 2010;
            newCar.Make = "Ford";
            newCar.Model = "Taurus";
            newCar.Name = "Dirty Scrubs";
            newCar.TelephoneContact = "888-212-4724";
            newCar.PassengerCount = 4;
            newCar.TrunkSpace = 24;
            newCar.Motto = "We can doctor up your mess!";
            newCar.LowGroundClearance = true;


            var newTruck = new Truck();
            newTruck.LicensePlateNum = "787-PMT";
            newTruck.Year = 2016;
            newTruck.Make = "Ford";
            newTruck.Model = "F-250";
            newTruck.Name = "Stinky Scoops Poops";
            newTruck.TelephoneContact = "888-462-9324";
            newTruck.PassengerCount = 4;
            newTruck.BedCapacity = 120;
            newTruck.Motto = "Your pup's stinks are our rink!";
            newTruck.Is4WD = true;

            var newSUV = new SUV();
            newSUV.LicensePlateNum = "BAX-CAX";
            newSUV.Year = 2014;
            newSUV.Make = "Honda";
            newSUV.Model = "Odyssey";
            newSUV.Name = "Diana's Bakery";
            newSUV.TelephoneContact = "888-539-2242";
            newSUV.PassengerCount = 4;
            newSUV.StorageCapacity = 80;
            newSUV.Motto = "We make the world a little sweeter!";
            newSUV.Is4WD = false;

            var vehicles = new List<IVehicle>() { newCar, newTruck, newSUV};
            foreach ( var vehicle in vehicles ) 
            {
                Console.WriteLine("----------------------------------------------------------");
                vehicle.VehicleNotes();
                Console.WriteLine("----------------------------------------------------------");
                vehicle.DrivingExample();
                Console.WriteLine("----------------------------------------------------------");
            }


        }
    }
}
