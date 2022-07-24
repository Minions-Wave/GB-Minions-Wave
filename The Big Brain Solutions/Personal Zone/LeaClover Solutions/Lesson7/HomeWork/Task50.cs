// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using GBhomework7;

namespace GBhomework7
{
    class Task50
    {

        public void GetTask50()
        {
            Text task50 = new();
            Methods method = new();
            task50.task2main();
            double[,] matrix = new double[3, 4];
            method.FillMatrix(matrix);
            method.PrintMatrix(matrix);
            method.str = Console.ReadLine();
            string [] arrayPosition = method.str.Split(' ');
            method.GetArrayElement(matrix, arrayPosition);
        }
    }
}