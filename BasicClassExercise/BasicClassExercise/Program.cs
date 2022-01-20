using System;

namespace BasicClassExercise
{
    internal class Program
    {
        public class Car
        {
            private string make;
            public string Make
            {
                get { return make; }
                set { make = value; }
            }

            private string model;
            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            private int year;
            public int Year
            {
                get { return year; }
                set { year = value; }
            }

            private string color;
            public string Color
            {
                get { return color; }
                set { color = value; }
            }

        }
        static void Main(string[] args)
        {
            Car myCar = new Car()
            {
                Make = "Tesla",
                Model = "S3XY",
                Color = "Red",
                Year = 2023
            };

            Console.WriteLine($"\nMy car's maker is: {myCar.Make}");
            Console.WriteLine($"\nThe model of my {myCar.Make} is {myCar.Model}");
            Console.WriteLine($"\nAnd it is a {myCar.Color} {myCar.Year} {myCar.Make}");
        }
    }
}