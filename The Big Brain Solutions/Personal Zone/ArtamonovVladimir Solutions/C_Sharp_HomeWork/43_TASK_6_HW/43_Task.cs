namespace VladimirArtamnov
{
    public static class HomeWork_Task_43
    {
        //Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
        //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

        public static void Main(string[] args)
        {
            Console.WriteLine("Заданы два уравнения y = k1 * x + b1, y = k2 * x + b2.");
            Console.WriteLine("Вам необходимо внести значения b1, k1, b2 и k2.");
            string text = "k1b1k2b2";
            double[,] functionsArray = new double[2, 2];
            ManualFillArray(functionsArray, text);
            // PrintArray(functionsArray);
            FindCrossPoint(functionsArray);
        }

        public static void ManualFillArray(double[,] array, string nameOfNumbers)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Введите число для переменной {Convert.ToString(nameOfNumbers[count]) + Convert.ToString(nameOfNumbers[count = count + 1])}:");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    count++;
                    //Console.Clear();
                }
            }
        }

        public static void FindCrossPoint(double[,] inputArray)
        {
            if (inputArray[0, 0] == inputArray[1, 0] && inputArray[1, 1] == inputArray[0, 1])
            {
                Console.WriteLine("Прямые абсолютно идентичны!");
            }
            else if (inputArray[0, 0] == inputArray[1, 0])
            {
                Console.WriteLine("Прямые параллельны!");
            }
            else
            {
                double coordinateX = (inputArray[1, 1] - inputArray[0, 1]) / (inputArray[0, 0] - inputArray[1, 0]);
                double coordinateY = Convert.ToDouble(inputArray[0, 0] * coordinateX + inputArray[0, 1]);
                Console.WriteLine($"Координаты точки пересечения: X = {coordinateX}, Y = {coordinateY}");

            }
        }

        // public static void PrintArray(double[,] incomingArray)
        // {
        //     for (int i = 0; i < incomingArray.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < incomingArray.GetLength(1); j++)
        //         {
        //             Console.Write($"{incomingArray[i, j]}, ");
        //         }
        //         Console.WriteLine();
        //     }
        // }

    }
}
