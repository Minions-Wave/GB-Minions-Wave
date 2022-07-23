using GBhomework7;

namespace GBhomework7
{
    class Text
    {
        public void maintext()
        {
            Console.Clear();
            Console.WriteLine("Выберите задачу, решение которой надо показать!");
            Console.WriteLine("-- введите цифру *1* для первой задачи (Задача 47)");
            Console.WriteLine("-- введите цифру *2* для второй задачи (Задача 50)");
            Console.WriteLine("-- введите цифру *3* для третьей задачи (Задача 52)");
        }

        public void task1main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали первую задачу (Задача 47)!");
            Console.WriteLine("Сгенерирован случайный массив размера 3х4 заполненый вещественными числами: ");
        }


        public void task2main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали вторую задачу (Задача 50)!");
            Console.WriteLine("Сгенерирован массив размера 3х4: ");
            Console.WriteLine("Введите через пробел цифры позиций элемента, который надо найти и показать: ");
        }

        public void task2result1(double [,] array, int row, int column)
        {
            Console.WriteLine($"Найден элемент массива по индексам и равен {array[row,column]}");
        }

        public void task2result2()
        {
            Console.WriteLine($"По введенным индексам нет элемента!");
        }

        public void task3main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали третью задачу (Задача 52)!");
            Console.WriteLine("Сгенерирован двумерный массив размера 3х4: ");
        }

        public void task3result(double average, int column)
        {
            Console.WriteLine($"Среднее арифметическое {column+1} столбца равно {average}");
        }

        public void mistake()
        {
            Console.WriteLine("Вы ввели недопустимое значение!!!");
            Console.WriteLine("Повторите попытку!");
        }

    }
}