using System;

namespace Program02 {
    internal class Cars : Vehicle {
        string modelType, companyName;

        public void getCar() {
            Console.WriteLine("Enter the model type of the car");
            modelType = Console.ReadLine();

            Console.WriteLine("Enter the company name of the car");
            companyName = Console.ReadLine();
        }
        public void showCar() {
            Console.WriteLine("The model type of the car is: " + modelType);
            Console.WriteLine("The company name of the car is: " + companyName);
        }
    }
}
