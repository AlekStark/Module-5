using static System.Console;

class MainClass
{

    static string ShowColor(string username, double userage)
    {
        WriteLine("{0}, {1}\n Напишите свой любимый цвет", username, userage);
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
        return color;
    }

    static void GetName(ref string name)
    {
        WriteLine("Введите имя");
        name = ReadLine();

    }

    public static void Main(string[] args)
    {

        /*var (name, age) = ("Евгения", 27);

        WriteLine("Мое имя: {0}", name);
        WriteLine("Мой возраст: {0}", age);*/

        (string name, double age) anketa;

        Write("Введите имя: ");
        anketa.name = ReadLine();



        Write("Введите возрас с цифрами:");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        WriteLine("Ваше имя: {0}", anketa.name);
        WriteLine("Ваш возраст: {0}", anketa.age);

        string[] favcolors = new string[3];
        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor(anketa.name, anketa.age);
        }
        WriteLine("Любимые цвета:");
        foreach (var color in favcolors)
        {
            WriteLine(color);
        }

        GetName(ref anketa.name);
        

        ReadKey();
    }
}