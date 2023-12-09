// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив символов
        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

        // Создаем строку из символов массива
        string resultString = ConvertCharArrayToString(charArray);

        // Выводим результат
        Console.WriteLine("Результирующая строка: " + resultString);
    }

    static string ConvertCharArrayToString(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        // Используем StringBuilder для эффективной конкатенации символов
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        // Итерируем по элементам массива и добавляем их в StringBuilder
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sb.Append(charArray[i, j]);
            }
        }

        // Возвращаем строку
        return sb.ToString();
    }
}

