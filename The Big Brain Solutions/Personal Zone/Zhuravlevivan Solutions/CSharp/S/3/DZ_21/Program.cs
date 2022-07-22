// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

namespace GeekBrains
{
    internal class NewBaseType
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Поиск расстояния между двух точек в 3D пространстве");

            Console.Write("Введите координаты первой точки через пробел: ");

            string[] a_point = Console.ReadLine().Split();
            int xa = int.Parse(a_point[0]);
            int ya = int.Parse(a_point[1]);
            int za = int.Parse(a_point[2]);

            Console.Write("Введите координаты второй точки через пробел: ");

            string[] b_point = Console.ReadLine().Split();
            int xb = int.Parse(b_point[0]);
            int yb = int.Parse(b_point[1]);
            int zb = int.Parse(b_point[2]);

            // Вводим промежуточную переменную для значения из которого будем извлекать корень
            // double temp = ((Math.Pow((xb - xa), 2))
            //             +  (Math.Pow((yb - ya), 2))
            //             +  (Math.Pow((zb - za), 2)));

            // double distance = Math.Round(Math.Sqrt(temp), 2);

            // double temp = ((Math.Pow((xb - xa), 2))
            //             +  (Math.Pow((yb - ya), 2))
            //             +  (Math.Pow((zb - za), 2)));

            double distance = Math.Round(Math.Sqrt(((Math.Pow((xb - xa), 2))
                                                + (Math.Pow((yb - ya), 2))
                                                + (Math.Pow((zb - za), 2)))), 2);

            Console.WriteLine($"Расстояние между точками: {distance}");

        }
    }
}
