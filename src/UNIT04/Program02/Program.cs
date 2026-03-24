/* 
    Definition 02
        Create a class “Vehicle” with instance variable vehicle_type. Inherit the class in a class called 
        “Car” with instance model_type, company name etc. display the information of the vehicle by defining 
        the show() in both super and subclass
*/

using System;

namespace Program02 {
    internal class Program {
        static void Main(String[] args) {

            Cars cars = new Cars();
            
            cars.getData();
            cars.showVehicle();
            cars.getCar();
            cars.showCar();
        }
    }
}