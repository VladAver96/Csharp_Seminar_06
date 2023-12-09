// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System;

class Program
{
    static void Main()
    {
        // Введите строку с латинскими буквами в обоих регистрах
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        // Формируем новую строку с заменой заглавных букв на строчные
        string resultString = ConvertToLowerCase(inputString);

        // Выводим результат
        Console.WriteLine($"Исходная строка: {inputString}");
        Console.WriteLine($"Результат: {resultString}");
    }

    // Функция для замены заглавных букв на строчные
    static string ConvertToLowerCase(string input)
    {
        // Используем метод ToLower для замены заглавных букв на строчные
        return input.ToLower();
    }
}

