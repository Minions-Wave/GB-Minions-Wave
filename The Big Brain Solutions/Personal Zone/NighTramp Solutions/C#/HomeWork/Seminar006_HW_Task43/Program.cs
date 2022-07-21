/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
namespace Task43
{
    class Dot
    {
        public double x {get; private set;}
        public double y {get; private set;}
        public double k1 {get; private set;}
        public double b1 {get; private set;}
        public double k2 {get; private set;}
        public double b2 {get; private set;}
        public Dot()
        {
            x = 0;
            y = 0;
            Console.WriteLine("Введите k1");
            k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b1");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k2");
            k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b2");
            b2 = Convert.ToInt32(Console.ReadLine());
        }
        public Dot(double X, double Y)
        {
            x = X;
            y = Y;
        }
        public void FindXY()
        {
            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;
        }
        public void ViewXY()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
    } 
    class Program
    {    
        static void Main(string[] asgs)
        {
            Dot M = new Dot();
            M.FindXY();
            M.ViewXY();
        }
    }
}