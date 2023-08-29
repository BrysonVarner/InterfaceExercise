using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */
        public string LicensePlateNum { get; set; }        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int PassengerCount { get; set; }
        public void DrivingExample();
        public void VehicleNotes();
    }
}
