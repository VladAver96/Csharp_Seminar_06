// Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;

class Program
{
    static void Main()
    {
        // Задаем произвольную строку
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        // Проверяем, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(inputString);

        // Выводим результат
        if (isPalindrome)
        {
            Console.WriteLine("Это палиндром!");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }

    // Функция для определения, является ли строка палиндромом
    static bool IsPalindrome(string input)
    {
        // Преобразуем строку к нижнему регистру для учёта регистра букв
        string lowerCaseInput = input.ToLower();

        // Убираем пробелы из строки
        string stringWithoutSpaces = new string(lowerCaseInput.ToCharArray()
                                           .Where(c => !Char.IsWhiteSpace(c))
                                           .ToArray());

        // Создаем обратную копию строки
        char[] charArray = stringWithoutSpaces.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        // Сравниваем исходную строку с её обратной копией
        return stringWithoutSpaces == reversedString;
    }
}

