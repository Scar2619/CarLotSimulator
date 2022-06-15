using System;
using System.Linq;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            

            //.dot syntax
            Car firstCar = new Car();
            firstCar.Year = 1999;
            firstCar.Make = "Chevy";
            firstCar.Model = "Cavalier";
            firstCar.EngineNoise = "Putt putt";
            firstCar.HonkNoise = "Baloooga!";
            firstCar.IsDriveable = true;

            //object initializer
            Car secondCar = new Car()
            {
                Year = 2000,
                Make = "Honda",
                Model = "Accord",
                EngineNoise = "Chuga Chuga",
                HonkNoise = "Wee Woo",
                IsDriveable = true
            };

            //constructor
            var thirdCar = new Car(2020, "Toyota", "Rav4", "Zooooom", "Boom snap", true);

            //Call methods
            //firstCar.MakeEngineNoise();
            //secondCar.MakeEngineNoise();
            //thirdCar.MakeEngineNoise();

            //firstCar.MakeHonkNoise();
            //secondCar.MakeHonkNoise();
            //thirdCar.MakeHonkNoise();

            //CarLot Adds
            //Count # of cars added to CarLot
            lot.Cars.Add(firstCar);
            
            lot.Cars.Add(secondCar);
   
            lot.Cars.Add(thirdCar);

            Console.WriteLine($"Current number of cars: {CarLot.numberOfCars}");

            //Iterate through list
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }








            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
