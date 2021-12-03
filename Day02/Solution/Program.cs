using System;
using System.IO;
using System.Linq;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");

            var horizontal = 0;
            var depth = 0;

            foreach(string line in input)
            {
                if(line.Contains("forward"))
                {
                    var value = Int32.Parse(line.Replace("forward", ""));
                    horizontal = horizontal+value;
                }

                if(line.Contains("up"))
                {
                    var value = Int32.Parse(line.Replace("up", ""));
                    depth = depth - value;
                }

                if(line.Contains("down"))
                {
                    var value = Int32.Parse(line.Replace("down", ""));
                    depth = depth + value;
                }
            }

            Console.WriteLine(horizontal * depth);
            //2215080
            
        }
    }
}
