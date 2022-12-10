using System;
using System.Collections.Generic;
using System.Linq;

namespace Olymp
{
    class DartChampions
    {
        public static void Main()
        {
            string FirstCommand = "911"; //Console.ReadLine();
            List<string> SecondCommand = new();
            for (int a = 0; a < 9; a++)
                for (int b = 0; b < 9; b++)
                    for (int c = 0; c < 9; c++)
                    {
                        string Sequence = a.ToString() + b.ToString() + c.ToString();
                        if (Sequence != FirstCommand)
                            SecondCommand.Add(Sequence);
                    }

            int FirstResult = int.Parse(FirstCommand[0].ToString()) + int.Parse(FirstCommand[1].ToString()) + int.Parse(FirstCommand[2].ToString());
            IEnumerable<string> Result = SecondCommand.Where(x => int.Parse(x[0].ToString()) + int.Parse(x[1].ToString()) + int.Parse(x[2].ToString()) < FirstResult);
            
            Console.WriteLine("Result.Count = " + Result.Count());
            Console.WriteLine("Result elements :");
            foreach (string Element in Result)
                Console.WriteLine(Element);
        }
    }
}