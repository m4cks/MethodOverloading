using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TrueCoders!");
        }
        
        public int Add(int num1, int num2)
        {
            return num1+ num2;
        }

        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public string Add(int num1, int num2, bool dollars)
        {
            var sum = num1 + num2;
            var str = sum + "";
            if (dollars)
            {
                if (sum != 1)
                {
                    str += " dollars";
                }
                else
                {
                    str += " dollar";
                }
            }

            return str;
        }
    }
}
