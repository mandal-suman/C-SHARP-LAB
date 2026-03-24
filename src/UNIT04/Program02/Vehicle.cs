using System;

namespace Program02 {
    internal class Vehicle {
        string vehicleType;

        public void getData() {
            Console.WriteLine("Enter the type of vehicle");
            vehicleType = Console.ReadLine();
        }

        public void showVehicle() {
            Console.WriteLine("The type of vehicle is: " + vehicleType);
        }
    }
}
