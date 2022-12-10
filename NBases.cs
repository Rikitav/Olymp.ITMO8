using System.Text;
using System.Collections.Generic;

namespace Olymp
{
    public static class Program
    {
        public static string ToDecimal(this string Number, int NBase)
        {
            int Step = 1;
            int Result = 0;
            for (int i = Number.Length - 1; i >= 0; i--)
            {
                Result += int.Parse(Number[i].ToString()) * Step;
                Step *= NBase;
            }
            return Result.ToString();
        }

        public static string FromDecimal(this string DecimalNumber, int NBase)
        {
            StringBuilder Result = new();
            int Number = Convert.ToInt32(DecimalNumber);
            while (Number > NBase)
            {
                Result.Append(Number % NBase);
                Number /= NBase;
            }
            Result.Append(Number);
            char[] Res = Result.ToString().ToCharArray();
            Array.Reverse(Res);
            Result = new();
            foreach (char ch in Res)
            {
                Result.Append(ch);
            }
            return Result.ToString();
        }

        public static void Main()
        {
            Console.Write("Писло : ");
            string n = Console.ReadLine();
            Console.Write("fromNBase : ");
            int fromNBase = Convert.ToInt32(Console.ReadLine());
            Console.Write("toNBase : ");
            int toNBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n.ToDecimal(fromNBase).FromDecimal(toNBase));
        }
    }
}

/*
for (int i = 0; i < EightBase.Length; i++)
{
    System.Text.StringBuilder EightBaseBuildString = new();
    foreach (char EightBaseChar in EightBase[i])
    {
        switch (EightBaseChar)
        {
            case '0':
                EightBaseBuildString.Append("000");
                break;
            
            case '1':
                EightBaseBuildString.Append("001");
                break;
            
            case '2':
                EightBaseBuildString.Append("010");
                break;
            
            case '3':
                EightBaseBuildString.Append("011");
                break;
            
            case '4':
                EightBaseBuildString.Append("100");
                break;
            
            case '5':
                EightBaseBuildString.Append("101");
                break;
            
            case '6':
                EightBaseBuildString.Append("110");
                break;
            
            case '7':
                EightBaseBuildString.Append("111");
                break;
        }
    }
    EightBase[i] = EightBaseBuildString.ToString();
}

//foreach (string str in EightBase)
//    Console.WriteLine(str);

/*
string result = string.Empty;
System.Collections.Generic.List<int[]> groups = new();
int rowsCount, seatsInRow, groupsCount;
Console.Write("Кол-во рядов : ");
rowsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Кол-во мест в 1 ряду : ");
seatsInRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Кол-во групп : ");
groupsCount = Convert.ToInt32(Console.ReadLine());

int outTheGroups;
Console.Write("Кол-во человек вне групп : ");
outTheGroups = Convert.ToInt32(Console.ReadLine());
outTheGroupsCount = outTheGroups + 1;
//for(int i = groups.Count - 1; i < groups.Count + outTheGroups; i++)
//    groups.Add(new int[] { i });

for (int i = 0; i < groupsCount; i++)
{
    Console.Write($"Кол-во человек в группе №{i} : ");
    int iGroupLength = Convert.ToInt32(Console.ReadLine());
    int[] iGroup = new int[3];

    for(int y = 0; y < iGroupLength; y++)
        iGroup[y] = i;
    if (iGroupLength != 3)
    {
        int NotExist = 3 - iGroupLength;
        outTheGroupsCount -+
    }

    groups.Add(iGroup);
}

//System.Collections.Generic.IEnumerable<int[]> Find = groups.Where(x => x.Length != seatsInRow);
*/