using System;
using static System.Console;

class Program
{
    private static void Main(string[] args)
    {
        (string FirstName, string LastName, int Age) MainUser;
        MainUser = Enteruser();
        WriteLine(MainUser.FirstName + " " + MainUser.LastName + " " + MainUser.Age);
    }
    static (string FirstName, string LastName, int Age) Enteruser()
    {
        (string FirstName, string LastName, int Age) User;

        WriteLine("Укажите имя:");
        User.FirstName = ReadLine();

        WriteLine("Укажите фамилию:");
        User.LastName = ReadLine();

        string age;
        int intage;
        do
        {
            WriteLine("Укажите возраст цифрами:");
            age = ReadLine();
        }
        while (CheckNum(age, out intage));

        User.Age = intage;
        return User;
    }

    static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }
        corrnumber = 0;
        return true;
    }
}