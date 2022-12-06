using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace AoC_Day_1
{
    internal class Program
    {
        private static int elfIndex;
        private static int elfCalorie;
        private static int currentElf = 1;
        private static int currentCalorie;
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("C:\\Users\\Matthew\\source\\repos\\AoC Day 1\\AoC Day 1\\input\\input.txt");
            foreach( var line in input)
            {
               if ( line == "")
                {
                    if (currentCalorie > elfCalorie)
                    {
                        elfCalorie = currentCalorie;
                        elfIndex = currentElf;
                    }
                    currentElf++;
                    currentCalorie = 0;

                }
                else
                {

                    currentCalorie += Int32.Parse(line);
                   
                }

            }
            Console.WriteLine(elfIndex);
            Console.WriteLine(elfCalorie);
        }
    }
}
