using GBhomework6;

namespace GBhomework6
{
    class Text
    {
        public void maintext()
        {
            Console.Clear();
            Console.WriteLine("Выберите задачу, решение которой надо показать!");
            Console.WriteLine("-- введите цифру *1* для первой задачи (Задача 41)");
            Console.WriteLine("-- введите цифру *2* для второй задачи (Задача 43)");
        }

        public void task1main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали первую задачу (Задача 41)!");
            Console.WriteLine("Введите несколько положительных и несколько отрицательных чисел через пробел: ");
        }

        public void task1result(int N)
        {
            Console.Write($"Среди введенных чисел число положительных равно {N}");
        }

        public void task2main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали вторую задачу (Задача 43)!");
            Console.WriteLine("Программа поиска точки пересечения двух прямых, заданных уравнениями: ");
            Console.WriteLine("y = k1 * x + b1");
            Console.WriteLine("y = k2 * x + b2");
        }

        public void task2k1()
        {
            Console.WriteLine("Введите k1: ");
        }
        public void task2b1()
        {
            Console.WriteLine("Введите b1: ");
        }
        public void task2k2()
        {
            Console.WriteLine("Введите k2: ");
        }
        public void task2b2()
        {
            Console.WriteLine("Введите b2: ");
        }

        public void task2result(double [] array)
        {
            Console.WriteLine($"Точкой пересечения двух прямых является (x = {array[0]}, y = {array[1]})!");
        }

        public void mistake()
        {
            Console.WriteLine("Вы ввели недопустимое значение!!!");
            Console.WriteLine("Повторите попытку!");
        }

    }
}