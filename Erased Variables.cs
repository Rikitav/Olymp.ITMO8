using System;
using System.Collections.Generic;
using System.Linq;

namespace Olymp
{
    class ErasedVariables
    {
        public static bool F(bool A, bool B, bool C) => !(A & C) | (C & B) | (A & !B); //Функция из задачи
        public static void Main()
        {
            Console.WriteLine(F(true, true, true)); //true
        }
    }
}