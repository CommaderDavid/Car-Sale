using System;

namespace CarDealership.Models {

    public class Car {
        // Public properties

        public string MakeModel { get; set; }
        public int Price { get; set; }
        public int Miles { get; set; }

        // Constructor

        public Car(string makeModel, int price, int miles)
        {
            MakeModel = makeModel;
            Price = price;
            Miles = miles;
        }

        public bool WorthBuying (int maxPrice) {
            return (Price < maxPrice);
        }

        public static string MakeSound(string sound)
        {
            return "Our cars sound like " + sound;
        }
    }
    
}