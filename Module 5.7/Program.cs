using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using static System.Console;

class Program
{
    private static void Main(string[] args)
    {
        //(string FirstName, string LastName, int Age, int HasPet, int CountPet) MainUser;
        var MainUser = Enteruser();
        string text = "Фамилия: " + MainUser.FirstName + "\nИмя: " + MainUser.LastName + "\nВозраст: " + MainUser.Age + "\nНаличие питомцев: " + MainUser.HasPet +
            "\nКоличество питомцев: " + MainUser.CountPet;

        WriteLine(text);
    }
    static (string FirstName, string LastName, int Age, bool HasPet, int CountPet, string[] PetName) Enteruser()
    {
        (string FirstName, string LastName, int Age, bool HasPet, int CountPet, string[] PetName) User;

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
        while (CheckNum(age, out intage, "Age"));

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
            while (CheckNum(countPet, out intage, "Pet"));

            if (intage == 0)
            {
                User.HasPet = false;
                User.CountPet = 0;
                User.PetName = new string[0];
            }
            else
            {
                User.HasPet = true;
                User.CountPet = intage;
                User.PetName = GetPetName(User.CountPet);
            }
        }
        else
        {
            User.CountPet = 0;
            User.HasPet = false;
            User.PetName = new string[0];
        }
        return User;
    }

    static bool CheckNum(string number, out int corrnumber, string Operation)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0 && Operation=="Age")
            {
                corrnumber = intnum;
                return false;
            }
            else if (intnum >= 0 && Operation == "Pet")
            {
                corrnumber = intnum;
                return false;
            }
        }
        corrnumber = 0;
        return true;
    }
    static string[] GetPetName(int countPet)
    {
        string [] petName = new string[countPet];
        for (int i = 0; i < countPet; i++)
        {
            WriteLine("Укажите кличку питомца {0}", i);
            petName[i] = ReadLine();
        }
        return petName; 
    }
}