using System;
using System.Collections.Generic;

namespace Olymp
{
    class HuntOnZombies
    {
        public static void Main()
        {
            int StartIndex = 40920; //int.Parse(Console.ReadLine());
            int EndIndex = 60916; //int.Parse(Console.ReadLine());
            List<int> Result = new();

            for (int SearchIndex = StartIndex; SearchIndex < EndIndex; SearchIndex++)
            {
                int Even = 0;
                int NotEven = 0;
                char[] Arr = SearchIndex.ToString().ToCharArray();

                Even += int.Parse(new ReadOnlySpan<char>(Arr, 1, 1));
                Even += int.Parse(new ReadOnlySpan<char>(Arr, 3, 1));
                NotEven += int.Parse(new ReadOnlySpan<char>(Arr, 0, 1));
                NotEven += int.Parse(new ReadOnlySpan<char>(Arr, 2, 1));
                NotEven += int.Parse(new ReadOnlySpan<char>(Arr, 4, 1));

                if (NotEven - Even == 21)
                    Result.Add(SearchIndex);
            }

            Console.WriteLine("Result.Count = " + Result.Count);
            Console.WriteLine("Result elements :");
            foreach (int Element in Result)
                Console.WriteLine(Element);
            return;
        }
    }
}