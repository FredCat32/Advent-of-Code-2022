using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// A Rock B Paper C Scissors
// X Rock Y Paperr Z Scissors

//123

namespace AoC_Day_1
{
    internal class Program
    {
     
        static void Main(string[] args)
        {


            var inputFile = File.ReadAllLines("C:\\Users\\Matthew\\source\\repos\\AoC Day 1\\AoC Day 1\\input\\input.txt");
            var input = new List<string>(inputFile);

            var inputScore = new Dictionary<string, int>()
            {
                {"X", 1},
                {"Y", 2},
                {"Z", 3},
            };

            int score = 0;
            foreach (var line in input)
            {
                var lineChoices = line.Split(new char[0]);

                var opponent = lineChoices[0];
                var mine = lineChoices[1];
                Console.WriteLine("hi");
                //draw
                if (opponent == "A" && mine == "X" ||
                    opponent == "B" && mine == "Y" ||
                    opponent == "C" && mine == "Z")
                {
                    score += 3 + inputScore[mine];
                }
                //win
                else if (opponent == "A" && mine == "Y" ||
                    opponent == "B" && mine == "Z" ||
                    opponent == "C" && mine == "X")
                {
                    score += 6 + inputScore[mine];
                }
                else
                {
                    score += inputScore[mine];
                }
            }
            Console.WriteLine(score.ToString());
        }

    }

       
   
}
