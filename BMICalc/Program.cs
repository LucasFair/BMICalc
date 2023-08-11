using System;

namespace BMICalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight;  // Kilograms
            double height;  // Meters

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("This is a BMI (Body Mass Index) calculator.\n");
            Console.WriteLine("Enter your weight in kilograms:");
            while (true)  // Prevents invalid inputs from crashing the console
            {
                Console.Write("> ");
                if (Double.TryParse(Console.ReadLine(), out weight)) break;
                Console.WriteLine("This is not a valid input.");
            }
            Console.WriteLine("Enter height in centimeters:");
            while (true)
            {
                Console.Write("> ");
                if (Double.TryParse(Console.ReadLine(), out height)) break;
                Console.WriteLine("This is not a valid input.");
            }
            double result = ((weight / 1000) * (height * height / 100));
            double resultShort = Math.Round(result, 3);
            Console.WriteLine("\nYour BMI is: " + resultShort);

            {
                if (resultShort < 16)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("You are below underweight. Please seek help.");
                    Console.ResetColor();  // This keeps only the line above colored
                }
                else if (resultShort <= 18.5)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your body weight is deficit. Please gain some weight, not through consuming double cream or heavy cream.");
                    Console.ResetColor();
                }
                else if (resultShort <= 24)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Your body weight is normal.");
                    Console.ResetColor();
                }
                else if (resultShort <= 30)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your body weight is above normal.");
                    Console.ResetColor();
                }
                else if (resultShort <= 35)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your body weight is at first degree obesity. Please contact a dietician.");
                    Console.ResetColor();
                }
                else if (resultShort <= 40)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your body weight is at second degree obesity. Please consult a doctor.");
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Your body weight is at third degree obesity. Please seek help.");
                    Console.ResetColor();
                }
                Console.WriteLine("\n\nThank you for using the Body Mass Index calculator.\n");
            }
        }
    }
}
