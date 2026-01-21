using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    private static void Main(string[] args)
    {
        var MainUser = Enteruser();
        string CountPetText ="";
        string CountColorText="";
        if (MainUser.CountPet > 0)
        {
            for (int i = 0; i < MainUser.CountPet; i++)
            {
                string petName;
                CountPetText = CountPetText + "\nИмя питомца {i+1}: " + MainUser.PetName[i];
            }
            //CountPetText = CountPetText.Remove(0, 2);
        }
        if (MainUser.CountColor > 0)
        {
            for (int i = 0; i < MainUser.CountColor; i++)
            {
                CountColorText = CountColorText + $"\nИмя питомца {i+1}: " +MainUser.ColorName[i];
            }
            //CountColorText = CountColorText.Remove(0, 2);
        }
        string text = $"Фамилия: {MainUser.FirstName}  \nИмя: {MainUser.LastName} \nВозраст: {MainUser.Age} \nНаличие питомцев: {MainUser.HasPet} \nКоличество питомцев: {MainUser.CountPet}" + CountPetText + $"\nКоличество цветов: {MainUser.CountColor}" + CountColorText;

        WriteLine(text);
    }
    static (string FirstName, string LastName, int Age, bool HasPet, int CountPet, string[] PetName, int CountColor, string[] ColorName) Enteruser()
    {
        (string FirstName, string LastName, int Age, bool HasPet, int CountPet, string[] PetName, int CountColor, string[] ColorName) User;

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
            User.PetName = GetName(User.CountPet, "Pet");
        }
        else
        {
            User.HasPet = false;
            User.CountPet = 0;
            User.PetName = new string[0];
        }
        string colorNum;
        do
        {
            WriteLine("Укажите количеество любимых цветов цифрами:");
            colorNum = ReadLine();
        }
        while (CheckNum(colorNum, out intage)); //цикл для проверки, что введины цифры.
        User.CountColor = intage;

        if (User.CountColor > 0)
        {
            User.ColorName = GetName(User.CountPet, "Color");
        }
        else
        {
            User.ColorName = new string[0]; 
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

    static string[] GetName(int countArr, string Operation)
    {
        string [] arrName = new string[countArr];
        for (int i = 0; i < countArr; i++)
        {
            string Name;
            do
            {
                if (Operation == "Pet")
                {
                    WriteLine("Укажите кличку питомца {0}. Имя должно быть уникальным", i+1);
                }
                else
                {
                    WriteLine("Укажите цвет {0}. Цвет должен быть уникальным", i+1);
                }
                Name = ReadLine();
            }
            while (CheckUniqueness(Name, arrName, out bool result));
            arrName[i] = Name;
        }
        return arrName; 
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
                    result = true;
                    return result;
                }
            }
            result = false;
         }
        else
        {
            result = true;
        }
        return result; 
    }
}