/*
Twin Prime Numbers from Coding Challenges
by Silvio Duka

Last modified date: 2018-04-03 

A twin prime is a prime number that is either 2 less or 2 more than another prime number. 
For example: (41, 43) or (149, 151) 

Write an program to find the twin prime numbers in a given range. 

For Example: 
Input: 0, 15 
Output: (3, 5), (5, 7), (11, 13)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0; // Insert a start number of range
            int end = 200; // Insert a end number of a range

            string result = String.Empty;

            for (int i = start; i <= end - 2; i++)
            {
                if (IsPrimeNumber(i) == true)
                {
                    if (IsPrimeNumber(i + 2) == true) result += String.Format($"({i.ToString()}, {(i + 2).ToString()}), ");
                }
            }

            Console.WriteLine($"Input: {start}, {end}");
            Console.WriteLine($"Output: {result.TrimEnd().TrimEnd(',')}");
        }

        static bool IsPrimeNumber(int n)
        {
            int r = 0;

            if (n <= 1) return false;

            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    r++;

                    if (r > 1) return false;
                }
            }

            return true;
        }
    }
 }