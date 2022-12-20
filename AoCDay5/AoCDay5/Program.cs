using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//[P][C][M]
//[D][P][B][V][S]
//[Q][V][R][V][G][B]
//[R][W][G][J][T][M][V]
//[V][Q][Q][F][C][N][V][W]
//[B][Z][Z][H][L][P][L][J][N]
//[H][D][L][D][W][R][R][P][C]
//[F][L][H][R][Z][J][J][D][D]
//1   2   3   4   5   6   7   8   9


namespace AoC_Day_1
{
    internal class Program
    {

        static void Main(string[] args)
        {


            var inputFile = File.ReadAllLines("C:\\Users\\Matthew\\source\\repos\\AoCDay5\\AoCDay5\\input.txt");
            var input = new List<string>(inputFile);


            var stacks = new List<string>[9];
               {
                new List<string>() { "P", "F", "M", "Q", "W", "G", "R", "T" };
                new List<string>() { "H", "F", "R" };
                new List<string>() { "P", "Z", "R", "V", "G", "H", "S", "D" };
                new List<string>() { "P", "S", "M", "J", "H" };
                new List<string>() { "M", "Z", "T", "H", "S", "R", "P", "L" };
                new List<string>() { "P", "T", "H", "N", "M", "L" };
                new List<string>() { "F", "D", "Q", "R" };
                new List<string>() { "D", "S", "C", "N", "L", "P", "H" };
           };

              foreach ( var line in input)
             {
                 var vals = line.Split("");
                 int move = Int32.Parse(vals[0]);   
                 int from = Int32.Parse(vals[1])-1;
                 int to = Int32.Parse(vals[2])-1;


             var currentStack = stacks[from];
                  for ( int i = 1; i <= move; i++)
             {

                     var crate = currentStack[currentStack.Count - 1];
                   stacks[to].Add(crate);
                   currentStack.RemoveAt(currentStack.Count - 1);


                }
             }
                 string output = "";
                 foreach( var stack in stacks)
           {
              output += stack[stack.Count - 1];

             }
                Console.WriteLine(output);
            }

        }
    }

