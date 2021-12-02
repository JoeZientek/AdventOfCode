using System;
using System.IO;
using System.Linq;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = File.ReadAllLines("input.txt");

            var count = 0;

            // start comparing second measurement to first measurement
            foreach(int measurementNumber in Enumerable.Range(1, input.Length - 1))
            {
                
                if (Int32.Parse(input[measurementNumber]) > Int32.Parse(input[measurementNumber - 1]))
                {
                    count++;
                }
                
            }

            Console.WriteLine(count);
        }
    }
}
