/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
namespace Task38
{
    class Dot
    {
        public int x {get; private set;}
        public int y {get; private set;}
        public int k1 {get; private set;}
        public int b1 {get; private set;}
        public int k2 {get; private set;}
        public int b2 {get; private set;}
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
        public Dot(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public void FindX()
        {

        }
    } 
    class Program
    {    
        static void Main(string[] asgs)
        {
            Dot M = new Dot();
        }
    }
}