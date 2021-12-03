using System;
using System.IO;
using System.Linq;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            // part A

            var input = File.ReadAllLines("input.txt").Select(x => int.Parse(x)).ToArray();

            var count = 0;

            // start comparing second measurement to first measurement
            foreach(int measurementNumber in Enumerable.Range(1, input.Length - 1))
            {
                if (input[measurementNumber] > input[measurementNumber - 1])
                    count++;
            }

            Console.WriteLine(count);

            // part B 
            var currentSum = input.Take(3).Sum();
            var numIncreases = 0;

            foreach(int measurementNumber in Enumerable.Range(1, input.Length - 1))
            {
                if(measurementNumber + 2 <= input.Length)
                {
                    var previousSum = currentSum;
                    currentSum = input.Skip(measurementNumber).Take(3).Sum();

                    if(currentSum > previousSum)
                        numIncreases++;
                }
            }

            Console.WriteLine(numIncreases);
        }
    }
}
