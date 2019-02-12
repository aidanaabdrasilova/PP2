using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; // Contains types that allow reading and writing to files and data streams
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void IsPrime()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Баха\Desktop\Книги\text.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Баха\Desktop\Книги\output.txt");
            string s = sr.ReadLine(); // Write the text down from the giving "input" file
            string[] arr = s.Split(); // Create the array where every element is written by spaces from s

            for (int k = 0; k < arr.Length; ++k) // Cycle which works from 0 to the length of the array
            {
                int a = int.Parse(arr[k]);  // Transfer k-th element of the array into int and write into a
                bool Check = true;
                if (a == 1 || a == 0) // Condition which changes "Check" if the number is  equal 1 or 0
                {
                    Check = false;
                }
                for (int j = 2; j < a; j++) // Cycle fo checking the number Which goes form 2 to a-1
                {
                    if (a % j == 0) // If the number "a" devides by j by remainder and eqauals.Check is equal False
                    {
                        Check = false;
                    }
                }
                if (Check == true) // If the Check = true. Show the number a which is prime
                {
                    sw.Write(a + " ");
                }
            }
            sr.Close();//
            sw.Close();// DO NOT FoRGET To Close

        }
        static void Main(string[] args)
        {
            IsPrime(); // Call The function "IsPrime"
            Console.ReadKey();
        }
    }
}