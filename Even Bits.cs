string[] input = System.IO.File.ReadAllLines("input.txt");
string[] copy = System.IO.File.ReadAllLines("copy.txt");
System.Collections.Generic.List<string> Words = new();

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Substring(1) == copy[i].Substring(1))
    {
        Words.Add(input[i].Substring(1));
        continue;
    }

    // 0 - чет
    // 1 - !чет

    int InputSum = 0;
    for (int x = 1; x < 5; x++)
        InputSum += Convert.ToInt32(input[i][x]);

    int CopySum = 0;
    for (int x = 1; x < 5; x++)
        CopySum += Convert.ToInt32(copy[i][x]);

    char FindEven = input[i][0];
    char[] find = new string[] { input[i], copy[i] }.Where(s => 
    {
        int Sum = 0;
        for (int x = 1; x < 5; x++)
            Sum += Convert.ToInt32(s[x]);
          
        return (Sum % 2).ToString() == FindEven.ToString();
    }).First().ToCharArray();

    for (int c = 1; c < 5; c++)
    {
        if (input[i][c] != copy[i][c])
        {
            find[c] = FindEven == '0' ? '1' : '0';
            string str = string.Empty;
            for(int h = 1; h < find.Length; h++)
                str += find[h];
            Words.Add(str);
            break;
        }
    }
}


string[] bits8 = new string[Words.Count / 2];
for (int i = 0; i < Words.Count; i++)
{
    bits8[i / 2] = Words[i] + Words[++i];
}

int[] result = new int[bits8.Length];
for (int i = 0; i < bits8.Length; i++)
{
    int Step = 128;
    foreach (char ch in bits8[i])
    {
        if (ch == '1')
            result[i] += Step;
        Step /= 2;
    }
}

foreach(string str in bits8)
{
    Console.WriteLine(str);
}

foreach(int i in result)
{
    Console.Write(i.ToString() + " ");
}