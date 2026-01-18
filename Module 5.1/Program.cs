using System;
using static System.Console;

class MainClass
{
    public static void Main(string[] args)
    {
        WriteLine("Цикл for");

        for (int i = 0; i < 3; i++)
        {
            WriteLine(i);

            WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = ReadLine();

            switch (color)
            {
                case "red":
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.Black;

                    WriteLine("Your color is red!");
                    break;

                case "green":
                    BackgroundColor = ConsoleColor.Green;
                    ForegroundColor = ConsoleColor.Black;

                    WriteLine("Your color is green!");
                    break;
                case "cyan":
                    BackgroundColor = ConsoleColor.Cyan;
                    ForegroundColor = ConsoleColor.Black;

                    WriteLine("Your color is cyan!");
                    break;
                default:
                    BackgroundColor = ConsoleColor.Yellow;
                    ForegroundColor = ConsoleColor.Red;

                    WriteLine("Your color is yellow!");
                    break;
            }
        }

        WriteLine("Цикл while");
        int k = 0;
        while (k < 3)
        {
            WriteLine(k);

            WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = ReadLine();

            switch (color)
            {
                case "red":
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.Black;

                    WriteLine("Your color is red!");
                    break;

                case "green":
                    BackgroundColor = ConsoleColor.Green;
                    ForegroundColor = ConsoleColor.Black;

                    WriteLine("Your color is green!");
                    break;
                case "cyan":
                    BackgroundColor = ConsoleColor.Cyan;
                    ForegroundColor = ConsoleColor.Black;

                    WriteLine("Your color is cyan!");
                    break;
                default:
                    BackgroundColor = ConsoleColor.Yellow;
                    ForegroundColor = ConsoleColor.Red;

                    WriteLine("Your color is yellow!");
                    break;
            }
        }

        WriteLine("Цикл do");
        int t = 0;

        do
        {
            WriteLine(t);

            WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = ReadLine();

            switch (color)
            {
                case "red":
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.Black;

                    WriteLine("Your color is red!");
                    break;

                case "green":
                    BackgroundColor = ConsoleColor.Green;
                    ForegroundColor = ConsoleColor.Black;

                    WriteLine("Your color is green!");
                    break;
                case "cyan":
                    BackgroundColor = ConsoleColor.Cyan;
                    ForegroundColor = ConsoleColor.Black;

                    WriteLine("Your color is cyan!");
                    break;
                default:
                    BackgroundColor = ConsoleColor.Yellow;
                    ForegroundColor = ConsoleColor.Red;

                    WriteLine("Your color is yellow!");
                    break;
            }

        } while (t < 3);

        ReadKey();
    }
}