﻿int[,] matrix = new int[3, 5];

Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        matrix[i, j] = rnd.Next(1, 11);
    }
}

// Вывод массива в консоль
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} "); //интерполяция строк
    }
    Console.WriteLine(); // Для перевода курсора на новую строку после вывода каждой строки массива
}