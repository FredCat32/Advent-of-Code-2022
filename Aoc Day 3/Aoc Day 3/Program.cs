using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace AoC_Day_3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Part2();
            var inputFile = File.ReadAllLines("C:\\Users\\Matthew\\source\\repos\\Aoc Day 3\\Aoc Day 3\\input.txt");
            var input = new List<string>(inputFile);

            var characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            int priorities = 0;

            foreach (var line in input)
            {
                var compartment1 = line.Substring(0, line.Length / 2);
                var compartment2 = line.Substring(line.Length / 2, line.Length / 2);

                foreach (var c in compartment2)
                {
                    if (compartment1.Contains(c))
                    {
                        priorities += Array.IndexOf(characters, c) + 1;
                        break;
                    }
                }




            }



            Console.WriteLine(priorities.ToString());
        }
        static void Part2()
        {
            {
                var inputFile = File.ReadAllLines("C:\\Users\\Matthew\\source\\repos\\Aoc Day 3\\Aoc Day 3\\input.txt");
                var input = new List<string>(inputFile);

                var characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                int priorities = 0;

                int lineCount = 0;
                var lines = new string[3];


                foreach (var line in input)
                {
                    if(lineCount < 3)
                    {
                        lines[lineCount] = line;
                        lineCount++;


                    }
                    if(lineCount == 3){
                        var charMatches = new List<char>();
                        foreach (var c in lines[1])
                        {
                            if (lines[0].Contains(c))
                            {
                                charMatches.Add(c);                         
                            }
                        }
                        foreach (var c in lines[2])
                        {
                            if (charMatches.Contains(c))
                            {
                                priorities += Array.IndexOf(characters, c) + 1;
                                break;
                            }
                        }
                        lines = new string[3];
                        lineCount = 0;


                    }
                }
                Console.WriteLine(priorities.ToString());
            }
          
        }

       
    }
    
}
