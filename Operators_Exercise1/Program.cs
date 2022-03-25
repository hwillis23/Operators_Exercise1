using System;

namespace Operators_Exercise1
{
    internal class Program
    {

        //add two integers and two decimals and return  the sum
        public static int Add(int num1, int num2)
        {
            var answer= num1 + num2;
            return answer;
            
        }
        //integers with decimals 
        public static decimal Add(decimal num1, decimal num2)
        {
            var decimalAns= num1 + num2;
            return decimalAns;
        }
        //two integers with a boolean
          public static string Add(int num1, int num2, bool combined)
        {
            var sum= num1 + num2;
            if (combined == true && sum > 1)
            {
                return $"{sum} dollars";
    
            } 
            else if (combined == true && sum == 1)

            {
                return $"{sum} dollar";

            }
            else 
            {
                return sum.ToString();

            }


        }
        
      

        static void Main(string[] args)
        {
            var answer = Add(12, 8);
            Console.WriteLine($"{answer}");

            var decimalAns = Add(35.0m, 69.9m);

            var sum = Add(4, 7,true);
            var sum2 = Add(0, 1, true);
            var sum3 = Add(0, 2, false);
            
        }
    }
}
