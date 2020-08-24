using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // explicit typing
            string variableName = "Hello";

            // inferred typing
            var varName = "Hello again";
            
            
            var a = 5;
            var b = 10;
            var div = a / b;
            var mod = a % b;
            Console.WriteLine($"{a} / {b} is {div} with a remainder of {mod}.");

            var r = 20;
            var pi = Math.PI;
            var areaOfCircle = pi * (r * r);
            Console.WriteLine($"{r} is the radius that was given, and using that info we calculate the area is {areaOfCircle}");

        }
    }
}
