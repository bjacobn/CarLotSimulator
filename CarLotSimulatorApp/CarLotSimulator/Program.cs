using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();
            

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars


            var firstCar  = new Car();
            firstCar.Year = 2021;
            firstCar.Make = "Honda";
            firstCar.Model = " Accord";
            firstCar.EngineNoise = "vroom";
            firstCar.HonkNoise = "beep";
            firstCar.IsDriveable = true;

            lot.Cars.Add(firstCar);



            var secondCar = new Car()
            {
                Year = 2022,
                Make = "Ford  ",
                Model = "Fusion",
                EngineNoise = "rrrrr",
                HonkNoise = "beep",
                IsDriveable = true,                
            };

            lot.Cars.Add(secondCar);



            var thirdCar = new Car(2020, "Toyota","Camery","zrrrr","honk", false );

            lot.Cars.Add(thirdCar);



            //Call each of the methods for each car

            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            firstCar.MakeHonkNoise(firstCar.HonkNoise);

            secondCar.MakeEngineNoise(secondCar.EngineNoise);
            secondCar.MakeHonkNoise(secondCar.HonkNoise);

            thirdCar.MakeEngineNoise(thirdCar.EngineNoise);
            thirdCar.MakeHonkNoise(thirdCar.HonkNoise);




            ////*************BONUS 1*************// 
            ///Set the properties utilizing the 3 different ways we learned about, one way for each car 

            //*************BONUS X 2*************//
            //It should have at least one property: a List of cars
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                
                Console.WriteLine ($"Year : {car.Year} Make : { car.Make} Model : { car.Model} EngineNoise : { car.EngineNoise} HonkNoise : {car.HonkNoise} isDriveable :  {car.IsDriveable}"); 


              

            }
        }
    }
}
