using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    private static void Main(string[] args)
    {
        //(string FirstName, string LastName, int Age, int HasPet, int CountPet) MainUser;
        var MainUser = Enteruser(); // Вызываем метод сбора данных
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
        while (CheckNum(age, out intage)); //цикл для проверки, что введины цифры.

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

            User.HasPet = true;
            User.CountPet = intage;
            User.PetName = GetPetName(User.CountPet);
        }
        else
        {
            User.HasPet = false;
            User.CountPet = 0;
            User.PetName = new string[0];
        }
        WriteLine("Есть ли у вас животные? Да или Нет");
        var pet = ReadLine();

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

    static string[] GetPetName(int countPet)
    {
        string [] petName = new string[countPet];
        for (int i = 0; i < countPet; i++)
        {
            string Name;
            do
            {
                WriteLine("Укажите кличку питомца {0}. Имя должно быть уникальным", i);
                Name = ReadLine();
            }
            while (CheckUniqueness(Name, petName, out bool result));
            petName[i] = Name;
        }
        return petName; 
    }

    static bool CheckUniqueness(string Name, string[] arr, out bool result)
    {
        string Pattern = "^[a-zA-Zа-яёА-ЯЁ]+$";
        if (Regex.IsMatch(Name, Pattern))
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Name == arr[i])
                {
                    result = false;
                    return result;
                }
            }
            result = true;
         }
        else
        {
            result = false;
        }
        return result; 
    }
}