using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{


    // Set the properties utilizing the 3 different ways we learned about, one way for each car
    //Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console

    class CarLot
    {
        public static int numberOfCar = 1;
        public List<Car> CarList { get; set; } = new List<Car>();
        
    }
}
