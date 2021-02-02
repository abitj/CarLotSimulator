using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car ----DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Instantiation 1
            CarLot lot = new CarLot();
            

            var myCar = new Car();
            lot.CarList.Add(myCar);

            myCar.Year = 2021;
            myCar.Make = "Jeep";
            myCar.Model = "Jeep Wrangler Unlimited Sahara";
            myCar.EngineNoise = "vroom";
            myCar.HonkNoise = "beep";
            myCar.IsDriveable = true;

          

            //Object Initializer

            var aguerCar = new Car() { 
            
            Year = 2022,
            Make = "Telsa",
            Model = "Cyber Truck",
            EngineNoise = "hoom",
            HonkNoise = "boom",
            IsDriveable = true
        };
            lot.CarList.Add(aguerCar);


            // Constructor Initialization

            var akoiCar = new Car(2023,"Toyota", "Highlander", "kroom",
            "koom", true);
            lot.CarList.Add(akoiCar);


            // methods call
            myCar.MakeEngineNoise();
            akoiCar.MakeEngineNoise();
            aguerCar.MakeEngineNoise();

            Console.WriteLine(".........................................");

            foreach (var car in lot.CarList)
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} and Model:{car.Model}");

            }
        }
    }
}
