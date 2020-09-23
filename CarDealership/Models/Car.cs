using System;
using System.Collections.Generic;

namespace CarDealership.Models 
{

    public class Car 
    {
        // Public properties

        public string MakeModel { get; set; }
        public int Price { get; set; }
        public int Miles { get; set; }
        
        static Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
        static Car yugo = new Car("1980 Yugo Koral", 700, 56000);
        static Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
        static Car amc = new Car("1976 AMC Pacer", 400, 198000);

        private static List<Car> _instances = new List<Car>() { volkswagen, yugo, ford, amc };

        // Constructor

        public Car(string makeModel, int price, int miles)
        {
            MakeModel = makeModel;
            Price = price;
            Miles = miles;
            _instances.Add (this);
        }

        public static List<Car> GetAll()
        {
            return _instances;
        }
    }
    
}