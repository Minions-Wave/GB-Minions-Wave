namespace Task
{
    class Task38manual
    {
        // Задача 38: Задайте массив вещественных чисел.
        // Найдите разницу между максимальным и минимальным элементов массива.
        // [3 7 22 2 78] -> 76
        public void returnTask38manual()
        {
            Console.Clear();
            Console.WriteLine("Вы смотрите решение для задачи No 38\n");
            Decisions forTask38Manual = new Decisions();
            double[] array = forTask38Manual.CreateManualArray();
            Methods objectTask38Manual = new Methods();
            //double[] array = objectTask38Manual.GetRandomArrayDouble(5, 7, -99, 100);
            Console.WriteLine("\nВы ввели следующий массив:\n");
            objectTask38Manual.PrintGotArray(array);
            double diff = forTask38Manual.DiffMaxMinElements(array);
            Console.WriteLine(
                $"\nИ разница у него между максимальным и\n"
                    + $"минимальным элементом массива равна = {Math.Round(diff, 3)}\n"
            );
            Console.Write("Нажмите любую клавишу для выхода в основное меню: ");
        }
    }
}
