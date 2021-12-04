using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = File.ReadAllLines("input.txt");
            var bitOneCounts = new List<int>();

            foreach(int bitNumber in Enumerable.Range(1, input[1].Length))
            {
                var oneCount = 0;
                foreach(string line in input)
                {

                    if(string.Equals(line.Substring(bitNumber-1, 1), "1"))
                    {
                        oneCount++;
                    }
                }

                bitOneCounts.Add(oneCount);
            }

            string gammaBinary = "";
            string epsilonBinary = "";

            foreach(int bit in bitOneCounts)
            {
                // if the count of 1s is greater than half the total number of input values ...
                if(bit > (input.Length/2))
                {
                    gammaBinary += "1";
                    epsilonBinary += "0";
                } 
                else 
                {
                    gammaBinary += "0";
                    epsilonBinary += "1";
                }
            }

            var gammaDecimal = Convert.ToInt32(gammaBinary, 2);
            var epsilonDecimal = Convert.ToInt32(epsilonBinary, 2);

            var pConsumption = gammaDecimal * epsilonDecimal;
            
            Console.WriteLine(pConsumption);
        }
    }
}
