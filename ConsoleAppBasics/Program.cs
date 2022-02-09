using System;

namespace ConsoleAppBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //DecimalNumbers();
            //NoneDeciamlnumbers();
            //InputIntVSDouble();

            //DateTimeBasics();

            /*
            double numberParesed = GetNumberFromUser();
            Console.WriteLine("Number was: {0}", numberParesed );
            */

            RandomNumbers();
        }

        private static void RandomNumbers()
        {
            Random randomGenerator = new Random();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Random number {i}: {randomGenerator.Next(1, 101)}" );
            }
        }

        static double GetNumberFromUser()
        {
            int numberOfTryes = 3;
            double number = 0;
            bool didParseNumber = false;

            while (didParseNumber == false && numberOfTryes > 0)
            {
                Console.Write("Enter a number: ");
                didParseNumber = double.TryParse(Console.ReadLine(), out number);
                
                numberOfTryes--;

                if ( ! didParseNumber)
                {
                    Console.WriteLine("You must enter a number!");
                }
            }

            return number;
        }

        private static void DateTimeBasics()
        {
            DateTime dateTimeNow = DateTime.Now;

            Console.WriteLine("Current date & time: " + dateTimeNow);
            Console.WriteLine("Current date & time in Ticks: " + dateTimeNow.Ticks);

            DateTime parsedDateTime = DateTime.Parse("1982-08-25");

            Console.WriteLine("My date: " + parsedDateTime);
            Console.WriteLine("My date (just date): " + parsedDateTime.ToShortDateString());
        }

        static void InputIntVSDouble()
        {
            Console.WriteLine("Input a int number");
            int intNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input a double number");
            double doubleNumber = Convert.ToDouble(Console.ReadLine());
        }

        private static void NoneDeciamlnumbers()
        {
            byte byteNumber = 255;

            short smallNumber = 32000;

            int standarndNumber = 123123123;

            long bigNumber = 123123L;

            Console.WriteLine("Max byte: " + byte.MaxValue);
            Console.WriteLine("Max short: " + short.MaxValue);
            Console.WriteLine("Max int: " + int.MaxValue);
            Console.WriteLine("Max long: " + long.MaxValue);
        }

        static void DecimalNumbers()
        {
            float smallDeciaml = 0.001f;//have to have a 'f' in the end

            double standardDecimal = 0.9923;

            decimal mostPreciseDecimal = 1.234M;//have to have a 'M' in the end

            Console.WriteLine("Max float: " + float.MaxValue);
            Console.WriteLine("Max double: " + double.MaxValue);
            Console.WriteLine("Max decimal: " + decimal.MaxValue);

            int numberA = (int)standardDecimal;

            Console.WriteLine("int from double: " + numberA);

            int convertUsingMath = (int)Math.Round(standardDecimal, 1);

            Console.WriteLine("int from double using Math.Round: " + numberA);
        }


    }
}
