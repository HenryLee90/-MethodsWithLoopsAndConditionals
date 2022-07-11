using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Write a method that will print to the console all numbers 1000 through - 1000------Done
            // Write a method that will print to the console numbers 3 through 999 by 3 each time------Done
            // Write a method to accept two integers as parameterss and check whether they are equal or not-----Done
            // Write a method to check whether a given number is even or odd-----Done
            ////Write a method to check whether a given number is positive or negative--------Done
            // Write a method to read the age of a candidate and determine whether they can vote.
            FirstHeadache();
            SecondHeadache();
            NowMigrane(5, 5);
            NowMigrane(5, 6);
            EvenOrOdd(-3);
            DoOrDonotHaveAHeadache(-7);



        }
       public static void FirstHeadache()
       {
      
            for (int i = 1000; i >= -1000; i--)
           {
                Console.WriteLine(i);
           }
       }
        public static void SecondHeadache()
        {
            for (int i = 3; i > 999; i += 3)
            {

                Console.WriteLine(i++);

            }
        }

        // Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void NowMigrane(int num1, int num2)  
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");

            }
            else
            {
                Console.WriteLine($"{num1} is not equal to {num2}");
            }            

        }

        // Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num1)
        {
         if (num1 % 2 ==0)
            {
                Console.WriteLine($"This is an even number");

            }
            else
            {
                Console.WriteLine($"This number is Odd");
            }
           


        }
        //Write a method to check whether a given number is positive or negative

        public static void DoOrDonotHaveAHeadache(int num1)
        {
            if (num1 < 0)
            {
                Console.WriteLine($"{num1} is thess than Zero");

            }
            Console.WriteLine($"{num1}is a positive number");
        }






    }
}       
