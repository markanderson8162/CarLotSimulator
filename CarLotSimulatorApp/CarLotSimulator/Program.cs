using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var firstCar = new Car("Ford", "Ranger", 1998);
            var secondCar = new Car("Chevrolet", "Camaro", 2004);
            var thirdCar = new Car("Toyota", "Camry", 1989);

            firstCar.IsDriveable = true;
            secondCar.IsDriveable = true;
            thirdCar.IsDriveable = false;

            firstCar.EngineNoise = "vrrooom";
            secondCar.EngineNoise = "VRROOOM";
            thirdCar.EngineNoise = "(silence)";

            firstCar.HonkNoise = "beep";
            secondCar.HonkNoise = "HONK";
            thirdCar.HonkNoise = "(silence)";

            string firstCarEngine = firstCar.MakeEngineNoise(firstCar.EngineNoise);
            string secondCarEngine = secondCar.MakeEngineNoise(secondCar.EngineNoise);
            string thirdCarEngine = thirdCar.MakeEngineNoise(thirdCar.EngineNoise);

            string firstCarHorn = firstCar.MakeHonkNoise(firstCar.HonkNoise);
            string secondCarHorn = secondCar.MakeHonkNoise(secondCar.HonkNoise);
            string thirdCarHorn = thirdCar.MakeHonkNoise(thirdCar.HonkNoise);

            Console.WriteLine($"My first car is {firstCar.Year} {firstCar.Make} {firstCar.Model}, it sounds like {firstCarEngine} {firstCarHorn}.");
            Console.WriteLine($"My second car is {secondCar.Year} {secondCar.Make} {secondCar.Model}, it sounds like {secondCarEngine} {secondCarHorn}.");
            Console.WriteLine($"My first car is {thirdCar.Year} {thirdCar.Make} {thirdCar.Model}, it sounds like {thirdCarEngine} {thirdCarHorn}.");

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
