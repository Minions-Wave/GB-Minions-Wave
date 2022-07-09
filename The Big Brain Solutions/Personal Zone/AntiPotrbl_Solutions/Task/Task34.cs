namespace Task
{
    public class Task34
    {
        // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
        // Напишите программу, которая покажет количество чётных чисел в массиве.
        // [345, 897, 568, 234] -> 2
        public void returnTask34()
        {
            Console.Clear();
            Console.WriteLine("Вы смотрите решение для задачи No 34\n");
            Methods objectTask34 = new Methods();
            int[] arrayTask34 = objectTask34.GetRandomArrayInt(5, 7, 100, 1000);
            Console.WriteLine(
                "Компьютер создал следующий массив,\n"
                    + "заполненный случайными положительными трехзначными цифрами\n"
            );
            objectTask34.PrintGotArray(arrayTask34);
            Console.WriteLine();
            Decisions forTask34 = new Decisions();
            int quantityEven = forTask34.GetQuantityEven(arrayTask34);
            Console.WriteLine($"С количеством четных чисел равным: {quantityEven}\n");
            Console.Write("Нажмите любую клавишу для выхода в основное меню: ");
        }
    }
}
