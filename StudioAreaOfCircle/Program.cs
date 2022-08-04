// See https://aka.ms/new-console-template for more information

using System;
using static StudioAreaOfCircle.Circle;


namespace StudioAreaOfCircle
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a radius:");
            string radiusInput = Console.ReadLine();

            double radius = double.Parse(radiusInput);

            Console.WriteLine($"The area of a circle of radius {radiusInput} is: {areaOfCircle(radius).ToString()}");
            Console.WriteLine($"The circumference of a circle of radius {radiusInput} is: {circumferenceOfCircle(radius).ToString()}");
            Console.WriteLine($"The diameter of a circle of radius {radiusInput} is: {diameterOfCircle(radius).ToString()}");

            Console.WriteLine("What is your car's MPG?:");
            string mpgInput = Console.ReadLine();

            double mpg = double.Parse(mpgInput);

            double gasUsed = circumferenceOfCircle(radius) / mpg;

            Console.WriteLine($"You will use {gasUsed.ToString()} gallons of gas to travel around a circle of radius {radiusInput}.");
        }
    }

}