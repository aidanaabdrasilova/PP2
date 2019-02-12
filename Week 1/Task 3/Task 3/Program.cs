using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int[] DoubArr(int[] a) // Method that makes out of an array of integers another array of integers,where every element is repeated
        {
            int[] array = new int[a.Length * 2]; // array with length of array which is sent
            int cnt = -1;
            for (int i = 0; i < a.Length; ++i) // cycle in which every element in array take value from the array which is sent twice
            {
                cnt++;
                array[cnt] = a[i];
                cnt++;
                array[cnt] = a[i];
            }
            return array; // return array  where every element is repeated
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] arc = s.Split();
            int[] array = new int[n]; // created array with n integers
            for (int k = 0; k < n; ++k) // Cycle in which every number in array takes every values from arc
            {
                array[k] = int.Parse(arc[k]);
            }
            int[] Ans = DoubArr(array); // Write the resulting double array into new Array
            for (int k = 0; k < Ans.Length; ++k)
            {
                Console.Write(Ans[k] + " "); // Show The new double array 
            }
            Console.ReadKey();
        }

    }
}
