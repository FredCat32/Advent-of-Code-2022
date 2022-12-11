
namespace AoC_Day_4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var inputFile = File.ReadAllLines("C:\\Users\\Matthew\\source\\repos\\AocDay4\\AocDay4\\input.txt");
            var input = new List<string>(inputFile);
            int count = 0;
            foreach(var line in input)
            {
                var assignments = line.Split(',');
              
                var elfOneNums = assignments[0].Split("-");
                var elfTwoNums = assignments[1].Split("-");
                Console.WriteLine(assignments[0]);
                Console.WriteLine(assignments[1]);
                Console.WriteLine(elfOneNums);
                Console.WriteLine(elfTwoNums);




                if ( Int32.Parse(elfTwoNums[0]) <= Int32.Parse(elfOneNums[0]) &&
                    Int32.Parse(elfTwoNums[1]) >= Int32.Parse(elfOneNums[1]) ||

                     Int32.Parse(elfTwoNums[0]) >= Int32.Parse(elfOneNums[0]) &&
                    Int32.Parse(elfTwoNums[1]) <= Int32.Parse(elfOneNums[1]))
                    {
                    count++;    
                }
            }
            Console.WriteLine(count);

        }
        

    }


}