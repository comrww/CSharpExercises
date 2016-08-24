using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        // Alright - your turn now!
        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            string YourName = "Hello " + name + "!";

            return YourName;
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int number1, int number2)
        {
            int TheSum = number1 + number2;

            return TheSum;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal number3, decimal number4)
        {
            decimal TheDividend = number3 / number4;

            return TheDividend;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            bool OpenFactor;

            if (age >= 18) {
                OpenFactor = true;
            }
            else {
                OpenFactor = false;
            }

            return OpenFactor;
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string FullName)
        {
            string[] ArrayOfName = FullName.Split(new char[] { ' ' }, 2);

            string FirstName = ArrayOfName[0];

            return FirstName;
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string OriginalString)
        {
            char[] charArray = OriginalString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string s)
        {
            if (s == null) return null;
            char[] charArray = s.ToCharArray();
            int len = s.Length - 1;

            for (int i = 0; i < len; i++, len--)
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }

            return new string(charArray);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
        public static string PrintTimesTable(int number)
        {
            string timesTable = string.Empty;

            for (int i = 1; i <= 10; i++)
            {
                if (i != 10)
                {
                    timesTable += $"{number} * {i} = {number * i}\r\n";
                }
                else
                {
                    timesTable += $"{number} * {i} = {number * i}";
                }
            }
            //Console.WriteLine(timesTable);
            return timesTable;
        }
        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double temp)
        {
            double solution = (temp - 273.15) * 9/5 + 32;
            solution = Math.Round(solution, 2);
            return solution;
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            double DoubleResult = Convert.ToDouble(result);
            DoubleResult = DoubleResult / array.Length;
            //Console.WriteLine(DoubleResult);
            return DoubleResult;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] array)
        {
            double average = array.Average();
            return average;
            //Console.WriteLine(average);
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
        public static string DrawTriangle(int number, int width)
        {
            string triangle = string.Empty;

            for (int i = width; i > 0; i--)
            {
                if (i < 2)
                {
                    triangle += number;
                    break;
                }
                else
                {

                    for (int j = 0; j < i; j++)
                    {
                        triangle += number;
                    }

                    triangle += "\r\n";
                }
            }

           
            //Console.WriteLine(triangle);
            return triangle;
        }
        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {
            //convert all time into seconds
            double HoursAsSeconds = hours * 3600;

            double MinutesAsSeconds = minutes * 60;

            double t = seconds + MinutesAsSeconds + HoursAsSeconds;

            double time = t / 3600;

            double velocity = distance / time;
            string finalOutcome = $"{Math.Round(velocity)}MPH";
            return finalOutcome;
        }
        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char pram)
        {
            bool myAwesomeVariable = "aeiouAEIOU".IndexOf(pram) >= 0;
            return myAwesomeVariable;
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char pram)
        {
            bool myAwesomeVariable = "aeiouAEIOU".IndexOf(pram) < 0;
            return myAwesomeVariable;
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int MyCoolInt)
        {
            if (MyCoolInt > 1)
            {
                int count = 0;

                while(MyCoolInt > 1)
                {
                    count++;
                    if (MyCoolInt % 2 == 0)
                    {
                        //is even
                        MyCoolInt = MyCoolInt / 2;
                    }
                    else
                    {
                        //is odd
                        MyCoolInt = (MyCoolInt * 3) + 1;
                    }
                }

                return count;
            }

            return 1;
        }
        // 17. THIS EXERCISE DOESN'T WORK FOR DOTNET CORE
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsLeapYear(DateTime value)
        {

            if ((value.Year % 4 == 0 && value.Year % 100 != 0) || (value.Year % 400 == 0))
            {
                bool LeapYearStatus = true;
                return LeapYearStatus;
            }
            else
            {
                bool LeapYearStatus = false;
                return LeapYearStatus;
            }
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        // Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months)
        public static int MortgageCalculator(decimal LoanBalance, decimal InterestRate, int LoanTerm, int PaymentPeriod)
        {
            double LoanBalanceAsDouble = Convert.ToDouble(LoanBalance);
            Console.WriteLine($"Double LoanBalance: {LoanBalanceAsDouble}");

            double InterestRateAsDouble = Convert.ToDouble(InterestRate);
            Console.WriteLine($"Double InterestRate: {InterestRateAsDouble}");

            int NumberOfPayments = LoanTerm * PaymentPeriod;
            Console.WriteLine($"Double NumberOfPayments: {NumberOfPayments}");

            double MonthlyInterestRate = (InterestRateAsDouble / 100) / PaymentPeriod;
            Console.WriteLine($"Double MonthlyInterestRate: {MonthlyInterestRate}");

            double CompoundedInterestRate = Math.Pow((1 + MonthlyInterestRate), NumberOfPayments);
            Console.WriteLine($"Double CompInterestRate: {CompoundedInterestRate}");

            // interest quotient (~0.004)
            double InterestQuotient = (MonthlyInterestRate * CompoundedInterestRate) / (CompoundedInterestRate - 1);
            Console.WriteLine($"Double CompInterestRate: {CompoundedInterestRate}");

            // final calculation rounded to two decimal places ($1432.25)
            double MonthlyPayment = Math.Round((LoanBalanceAsDouble * InterestQuotient) * 100) / 100;
            Console.WriteLine($"Double MonthlyPayment: {MonthlyPayment}");

            int MonthlyPaymentAsInt = Convert.ToInt32(MonthlyPayment);
            Console.WriteLine($"Int MonthlyPayment: {MonthlyPaymentAsInt}");

            return MonthlyPaymentAsInt;
        }
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}