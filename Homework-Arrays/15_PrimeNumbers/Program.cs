using System;


class PrimeNumbers
    {
        static void Main(string[] args)
        {
            // Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

            bool[] marked = new bool[10000000];
            int p = 2;
            int temp = 2;

            while (p < marked.Length && marked[p] != true )
            {
                for (int i = p + p; i < marked.Length; i += p)
                {
                    marked[i] = true;

                }

                temp++;

                while (temp < marked.Length && marked[temp] == true)
                {
                    temp++;
                    p = temp - 1;
                }
                
                p++;
            }

            for (int i = 2; i < marked.Length; i++)
            {
                
                if (marked[i] == false)
                {
                    Console.WriteLine("Prime Numbers are: {0}", i);
                }

            }
        }
    }

