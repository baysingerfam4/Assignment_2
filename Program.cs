using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading.Channels;
using System.Diagnostics.Metrics;
using System.Text;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carla Baysinger
            // CSI 120
            // Assignment 2 ints, floats, try catch, readline

            Question1();
            Question2();
            Question3();
            Question4();
            Question5();
            Question6();
            Question7();

        }

        public static void Question1()
        {

            //Question1();
            //1. Write a program that prompts the user to input five decimal numbers.  Your program should do the following:
            //a.Prompts the user to input five decimal numbers.
            //b.Prints the five decimal numbers.
            //c.Add the five decimal numbers.
            //d.Print the sum and the average of the five decimals. Calculating the sum and the average are two separate calculations.

            float number1 = 0f;
            try
            {
                Console.Write("Enter decimal number1 ");
                string userInput = Console.ReadLine();
                number1 = float.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }
            float number2 = 0f;
            try
            {
                Console.Write("Enter decimal number2 ");
                string userInput = Console.ReadLine();
                number2 = float.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }

            float number3 = 0f;
            try
            {
                Console.Write("Enter decimal number3 ");
                string userInput = Console.ReadLine();
                number3 = float.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }

            float number4 = 0f;
            try
            {
                Console.Write("Enter decimal number4 ");
                string userInput = Console.ReadLine();
                number4 = float.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }

            float number5 = 0f;
            try
            {
                Console.Write("Enter decimal number5 ");
                string userInput = Console.ReadLine();
                number5 = float.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }

            float Q1 = number1 + number2 + number3 + number4 + number5;

            float fi = 5;

            float average = Q1 / fi;

            Console.WriteLine($"{number1} + {number2} + {number3} + {number4} + {number5} = {Q1}");
            Console.WriteLine($"Question 1 average: {Q1} / {fi} = {average}");
        } // Question 1

        public static void Question2()
        {
            // Write a program that prompts the capacity, in gallons, of an automobile fuel tank and the miles per gallon the automobile can be driven.The program outputs the number of miles the automobile can be driven without refueling.
            int gallons = 17;
            int miles = 19;
            int equation = gallons * miles;
            Console.WriteLine(equation);
        } //question 2

        public static void Question3()
        {
            //Write a  program that prompts the user to input the elapsed time for an event in seconds. The program then outputs the elapsed time in hours, minutes, and seconds. (For example, if the elapsed time is 9630 seconds, then the output is 2:40:30.)

            int seconds = 0;
            try
            {
                Console.Write("Enter the elapsed time for an event in seconds: ");
                string userInput = Console.ReadLine();
                seconds = int.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }
            int onehour = 3600; // seconds in an hour
            int mininhour = 60; // minutes in an hour
            int problem1 = seconds / onehour; //how I got hours
            int problem2 = onehour * problem1;
            int problem3 = seconds - problem2;
            int problem4 = problem3 / mininhour; //how I got minutes
            int problem5 = mininhour * problem4;
            int problem6 = problem3 - problem5; //how I got seconds
            Console.WriteLine($"{problem1} hours, {problem4} minutes, {problem6} seconds ");
            
        } //question 3

        public static void Question4()
        {
            //Write a  program that prompts the user to input the elapsed time for an event in hours, minutes, and seconds. The program then outputs the elapsed time in seconds.

            int Hours = 0;
            int Minutes = 0;
            int Seconds = 0;
            
                Console.Write("Enter the elapsed time for an event in Hours: ");
                string userInput = Console.ReadLine();
                Console.Write("Enter the elapsed time for an event in Minutes: ");
                string userInput1 = Console.ReadLine();
                Console.Write("Enter the elapsed time for an event in Seconds: ");
                string userInput2 = Console.ReadLine();
                Hours = int.Parse(userInput);
                Minutes = int.Parse(userInput1);
                Seconds = int.Parse(userInput2);
            
            int onehour = 3600; // seconds in an hour
            int mininhour = 60; // minutes in an hour
            int problem1 = Hours * onehour; //how I turned hours to seconds
            int problem2 = Minutes * mininhour; //how I turned minutes to seconds
            int problem3 = problem1 + problem2 + Seconds;
            Console.WriteLine($"{problem1} + {problem2} + {Seconds} = {problem3}");

        } //question 4
        public static void Question5()
        {
            //To make a profit, a local store marks up the prices of its items by a certain percentage. Write a program that reads the original price of the item sold, the percentage of the marked-up price, and the sales tax rate. The program then outputs the original price of the item, the percentage of the mark-up, the store’s selling price of the item, the sales tax rate, the sales tax, and the final price of the item. (The final price of the item is the selling price plus the sales tax.)

            double Orig = 49.99;
            double Per = 20;
            double tax = 10.2;
            double m = 100;
            double per2 = Orig * Per / m; //20% of 49.99
            double saleprice = per2 + Orig; // sales price of the item
            double salestax = tax * saleprice / m; // sales tax amount

            double final = saleprice + salestax;

            double roundedNumber = Math.Round(final, 2);

            Console.WriteLine($"Original price {Orig}, pecentage of the mark up {Per}, store's selling price {saleprice}, sales tax rate {tax}, sales tax {salestax}");
            Console.WriteLine("Final Sale price:");
            Console.WriteLine(roundedNumber.ToString("c"));



        } // question 5
        public static void Question6()
        {

            // 1. Ask user for length in centimeters
            int centimeters = 0;
            try
            {
                Console.Write("Enter a length in centimeters ");
                string userInput = Console.ReadLine();
                centimeters = int.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }


            // 1a. Parse user length to number
            // 1b. Wrap in a try / catch
            // 2. Convert users length to inches
            double convertedToInches = Math.Round(centimeters / 2.54);
            Console.WriteLine(convertedToInches);
            // 2b. Get the conversion
            // 3. Convert to yards, feet, and inches
            int inchesInYard = 36;
            //Getting whole number of yards
            int yards = (int)convertedToInches / 36;
            //Getting remaining inches
            convertedToInches %= inchesInYard;

            // Getting the inches
            int inchesInFoot = 12;
            int feet = (int)convertedToInches / inchesInFoot;

            //Get remaining inches
            convertedToInches %= inchesInFoot;
            int inches = (int)convertedToInches;

            // 3 yards, 1 feet(foot), and 3 inch(es)
            Console.WriteLine($"{yards} yard(s), {feet} feet (foot), and {inches} inch(es)");
            // Display
        } // question 6

        public static void Question7()
        {
            // A milk carton can hold 3.78 liters of milk. Each morning, a dairy farm ships cartons of milk to a local grocery store. The cost of producing one liter of milk is $0.38, and the profit of each carton of milk is $0.27. Write a program that does the following:

            //a.Prompts the user to enter the total amount of milk produced in the morning.

            //b.Outputs the number of milk cartons needed to hold milk. (Round your answer to the nearest integer.)

            //c.Outputs the cost of producing milk.

            //d.Outputs the profit for producing milk.

            double Milk = 0;
            
            Console.Write("Enter the total amount of milk produced in the morning: ");
            string userInput = Console.ReadLine();
            Milk = int.Parse(userInput);

            double carton = 3.78;
            double b = Milk / carton;
            double cost = 0.38;
            double costofproducing = Milk * cost;

            double profit = 0.27;
            double Totalprofit = Milk * profit;

            double roundedNumber = Math.Round(b, 2);

            Console.WriteLine(roundedNumber);
            Console.WriteLine(costofproducing);
            Console.WriteLine(Totalprofit);


        } // Question 7


    }
}
