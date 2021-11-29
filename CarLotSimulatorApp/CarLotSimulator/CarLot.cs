using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    //Create a CarLot class

    public class CarLot
    {
        public CarLot()
        {

        }

        public List<Car> Cars = new List<Car>();

        //Create static field / Count start index 1
        public static int numberOfCars = 1;
    }
}
