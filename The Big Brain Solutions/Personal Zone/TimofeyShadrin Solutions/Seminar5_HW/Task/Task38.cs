namespace Task
{
    class Task38
    {
        // Задача 38: Задайте массив вещественных чисел.
        // Найдите разницу между максимальным и минимальным элементов массива.
        // [3 7 22 2 78] -> 76
        public void returnTask38()
        {
            Console.Clear();
            Console.WriteLine("Вы смотрите решение для задачи No 38\n");
            Decisions forTask38 = new Decisions();
            //double[] array = forTask38.CreateManualArray(5);
            Methods objectTask38 = new Methods();
            double[] array = objectTask38.GetRandomArrayDouble(5, 7, -99, 100);
            Console.WriteLine(
                "Компьютер создал следующий массив,\n"
                    + "заполненный случайными вещественными числами.\n"
            );
            objectTask38.PrintGotArray(array);
            Console.WriteLine();
            double diff = forTask38.DiffMaxMinElements(array);
            Console.WriteLine(
                "И с разницей между максимальным и минимальным элементом массива,\n"
                    + $"равной: {Math.Round(diff, 3)}\n"
            );
            Console.Write("Нажмите любую клавишу для выхода в основное меню: ");
        }
    }
}
