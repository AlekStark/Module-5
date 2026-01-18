using System;
using static System.Console;

namespace Module5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            WriteLine("Введите имя");
            User.Name = ReadLine();
            User.Dishes = new string[5];

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                WriteLine("Введите название блюда номер {0}", i + 1);
                User.Dishes[i] = ReadLine();
            }
            ReadKey();
        }
    }
}