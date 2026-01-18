using System;
using static System.Console;

class MainClass
{

    static void ShowColor()
    {
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

    public static void Main(string[] args)
    {

        var (name, age) = ("Евгения", 27);

        WriteLine("Мое имя: {0}", name);
        WriteLine("Мой возраст: {0}", age);

        Write("Введите имя: ");
        name = ReadLine();
        Write("Введите возрас с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        WriteLine("Ваше имя: {0}", name);
        WriteLine("Ваш возраст: {0}", age);

        ShowColor();


    }
}