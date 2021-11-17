using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    //Create a seperate class file called Car
    public class Car
    {

        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

        //Contstructor 1
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        //Constructor 2
        public Car()
        {
        }


        //Constructor 3
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

       


        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
       
        public void MakeEngineNoise(string  engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

    }
}
