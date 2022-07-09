namespace Task
{
    class Task36
    {
        // Задача 36: Задайте одномерный массив, заполненный случайными числами.
        // Найдите сумму элементов, стоящих на нечётных позициях.
        // [3, 7, 23, 12] -> 19
        // [-4, -6, 89, 6] -> 0
        public void returnTask36()
        {
            Console.Clear();
            Console.WriteLine("Вы смотрите решение для задачи No 36\n");
            Methods objectTask36 = new Methods();
            int[] arrayTask36 = objectTask36.GetRandomArrayInt(5, 7, -99, 100);
            Console.WriteLine(
                "Компьютер создал следующий массив,\n"
                    + "заполненный случайными числами.\n"
            );
            objectTask36.PrintGotArray(arrayTask36);
            Console.WriteLine();
            Decisions forTask36 = new Decisions();
            int sum = forTask36.GetSumOfOddPositions(arrayTask36);
            Console.WriteLine($"И с суммой элементов, стоящих на нечетных позициях и равной: {sum}\n");
            Console.Write("Нажмите любую клавишу для выхода в основное меню: ");
        }
    }
}
