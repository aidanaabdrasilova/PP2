using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool IsPrime(int number) // Bool function which returns true or false
        {
            if (number == 1 || number == 0) return false;// If number equal to 1 or 0 it will return false
            for (int k = 2; k < number; ++k) // From 2 to number
            {
                if (number % k == 0) return false; // Returns false if number by dividing by the remainder is egual to 0
            }
            return true; // Returns true if the above conditions does not match
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Variable n which is the amount of numbers in array
            string s = Console.ReadLine();
            string[] a = s.Split(); // An array in which every element is the number from s devided by space
            int[] array = new int[n]; // An array with n numbers
            for (int k = 0; k < n; ++k)
            {
                array[k] = int.Parse(a[k]); // Record every value from a into int to array
            }
            int cnt = 0; // Calculates prime numbers
            for (int k = 0; k < n; ++k)
            {
                if (IsPrime(array[k]) == true) // Condition which is performed if the function  returns true 
                {
                    cnt++; // Counting prime numbers
                }
            }
            Console.WriteLine(cnt); // Amount of prime numbers
            for (int k = 0; k < n; ++k)
            {
                if (IsPrime(array[k]) == true) // Function returns true if number is prime
                    Console.Write(array[k] + " "); // Show prime numbers
            }
            Console.ReadKey(); // Works until press any key
        }

    }
}