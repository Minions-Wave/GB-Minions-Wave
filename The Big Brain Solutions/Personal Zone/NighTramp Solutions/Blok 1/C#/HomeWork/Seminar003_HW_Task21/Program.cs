/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
namespace Task21
{
    class Dot
    {
        public int x;
        public int y;
        public int z;
        public void InitDot(char litera)
        {
           Console.WriteLine("Ведите коордитаны точки " + litera);
           x = int.Parse(Console.ReadLine());
           y = int.Parse(Console.ReadLine());
           z = int.Parse(Console.ReadLine());
           Console.WriteLine("Вы ввели: {0}({1},{2},{3});", litera, x, y, z);
        }
    }
    class Line
    {
        private Dot a;
        private Dot b;
        private double length;
        public void InitLine()
        {
            a = new Dot();
            b = new Dot();
            a.InitDot('A');
            b.InitDot('B');
        }
        public void LengthLine()
        {
            length = Math.Sqrt(Math.Pow(b.x - a.x, 2) + 
                               Math.Pow(b.y - a.y, 2) + 
                               Math.Pow(b.z - a.z, 2));
        }
        public double GetLength()
        {
            return length;
        }
    }
    class Program
    {
        static void Main(string[] asgs)
        {
            Line line = new Line();
            line.InitLine();
            line.LengthLine();
            Console.WriteLine("Расстояние между А и B равно: {0}", line.GetLength());
        }
    }
}