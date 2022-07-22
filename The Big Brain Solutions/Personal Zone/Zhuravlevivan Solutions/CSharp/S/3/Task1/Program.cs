/* Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. */

namespace GeekBrains
{
    class Program
    {
        public static void Main(string[] args)
        {
           Console.Write("Input X: ");
           int x = Convert.ToInt32(Console.ReadLine());
           Console.Write("Input Y: ");
           int y = Convert.ToInt32(Console.ReadLine());

           if(x<0 && y<0)
           {
            Console.WriteLine("Четверть III");
           }
           if(x<0 && y>0)
           {
            Console.WriteLine("Четверть II");
           }
           if(x>0 && y>0)
           {
            Console.WriteLine("Четверть I");
           }
           if(x>0 && y<0)
           {
            Console.WriteLine("Четверть IV");
           } 
        }
        
    }
}