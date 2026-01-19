using System;
using System.Diagnostics.Metrics;
using static System.Console;

class Program
{
    private static void Main(string[] args)
    {
        (string FirstName, string LastName, int Age, int HasPet, int CountPet) MainUser;
        MainUser = Enteruser();
        WriteLine("Фамилия: " + MainUser.FirstName + "\nИмя: " + MainUser.LastName + "\nВозраст: " + MainUser.Age /*+ "\nКоличество питомцев: " + MainUser.Pet*/);
    }
    static (string FirstName, string LastName, int Age, bool HasPet, int CountPet) Enteruser()
    {
        (string FirstName, string LastName, int Age, bool HasPet, int CountPet) User;

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

        WriteLine("Есть ли у вас животные? Да или Нет");
        var pet = ReadLine();

        if (pet == "Да")
        {
            string countPet;
            do
            {
                
                WriteLine("Укажите количество питомцев цифрами:");
                countPet = ReadLine();
            }
            while (CheckNum(countPet, out intage));

            if (intage == 0)
            {
                User.HasPet = false;
                User.CountPet = 0;
            }
            else
            {
                User.HasPet = true;
                User.CountPet = intage;
            }
        }
        else
        {
            User.CountPet = 0;
            User.HasPet = false;
        }
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