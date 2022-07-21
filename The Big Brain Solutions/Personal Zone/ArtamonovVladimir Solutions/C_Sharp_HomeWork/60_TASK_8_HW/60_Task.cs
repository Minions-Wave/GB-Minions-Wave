namespace VladimirArtamonov
{
    public static class HomeWorkTask60
    {
        //Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
        //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        //Массив размером 2 x 2 x 2
        //12(0,0,0) 22(0,0,1)
        //45(1,0,0) 53(1,0,1)

        public static void Main(string[] args)
        {
            Console.WriteLine("Вы должны задать трехмерный массив, в котором не должно быть ячеек более чем 90, если ошибетесь, то будете вводить заново!");
            bool checkCube = true;
            int rowLength = 1,
                columnLength = 1,
                depthLength = 1;
            while (checkCube)
            {
                Console.WriteLine("Введите количество строк в массиве:");
                rowLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество колонок в массиве:");
                columnLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество рядов (в глубину) в массиве:");
                depthLength = Convert.ToInt32(Console.ReadLine());
                if (rowLength * columnLength * depthLength <= 90)
                {
                    checkCube = false;
                }
                else
                {
                    Console.WriteLine("В данном массиве не получится внести только уникальные 2х значные числа!");
                }
            }
            int[,,] threeDimensionalArray = new int[rowLength, columnLength, depthLength];
            RandomFillThreeDimensionalArrayUniqueNumbers(threeDimensionalArray);
            Console.WriteLine("3D Массив:");
            PrintArray(threeDimensionalArray);
        }

        public static void RandomFillThreeDimensionalArrayUniqueNumbers(int[,,] array)
        {
            List<int> uniqueCollection = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        bool checkUniqueNumber = true;
                        while (checkUniqueNumber)
                        {
                            array[i, j, k] = new Random().Next(10, 100);
                            if (array[i, j, k] == uniqueCollection.Find(x => x == array[i, j, k]))
                            {
                                checkUniqueNumber = true;
                            }
                            else
                            {
                                uniqueCollection.Add(array[i, j, k]);
                                checkUniqueNumber = false;
                            }
                        }
                    }
                }
            }
        }

        public static void PrintArray(int[,,] incomingArray)
        {
            for (int i = 0; i < incomingArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomingArray.GetLength(1); j++)
                {
                    for (int k = 0; k < incomingArray.GetLength(2); k++)
                    {
                        Console.Write($"{incomingArray[i, j, k]} ({i}, {j}, {k}) ");
                    }
                    Console.WriteLine();
                }
                //Console.WriteLine();
            }
        }

    }
}
