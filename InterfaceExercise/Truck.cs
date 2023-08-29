﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public Truck()
        { }

        public string LicensePlateNum { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int PassengerCount { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }
        public string TelephoneContact { get; set; }
        public bool Is4WD { get; set; }
        public int BedCapacity { get; set; }

        public void DrivingExample()
        {
            Console.WriteLine($"When driving your {Year.ToString()} {Make} {Model}, license plate number {LicensePlateNum}; make sure you are curtious and do not drive aggressivly.");
            Console.WriteLine($"This would have the possibility of running off {Name}'s prospective customers, and make a bad first impression.");
            Console.WriteLine($"Please make sure {Name}'s vehicle is kept as clean as possible. This will help our customer's impressions of our team.");
            Console.WriteLine($"We want to make sure our phone number, {TelephoneContact}, is clearly visible at all times.");
            Console.WriteLine($"We want to welcome you to our team, and remember our company motto: {Motto}");
        }
        public void VehicleNotes()
        {
            Console.WriteLine($"Remember that you can only have other employees as passengers in {Name}'s Vehicles, even though there is space for {PassengerCount.ToString()} in the vehicle.");
            Console.WriteLine($"You can store and transport up to {BedCapacity.ToString()} cubic feet securely in the bed.");
            if (Is4WD)
            {
                Console.WriteLine($"The {Year.ToString()} {Make} {Model} has 4WD if you need to transport over difficult terrain, or in inclement weather.");
                Console.WriteLine("Remember to verify the vehicle is in \"Park\" before enabling 4WD to prevent damage to the vehicle.");
            }
            else
            {
                Console.WriteLine($"The {Year.ToString()} {Make} {Model} does not have 4WD. Please be cautious when transporting over difficult terrain, or in inclement weather.");
            }
        }
    }
}
