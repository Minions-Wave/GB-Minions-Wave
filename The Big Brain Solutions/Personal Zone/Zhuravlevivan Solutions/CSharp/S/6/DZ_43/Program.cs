// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2;
// y =  a * x + c,  y = b  * x + d
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


namespace DZ43
{
	class Program
	{
		public static void Main()
		{
			try
			{

				Console.Write("Введите b1: ");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите k1: ");
                double k1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b2: ");
                double b2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите k2: ");
                double k2 = Convert.ToDouble(Console.ReadLine());

                double x = (b2-b1)/(k1-k2);
                double y = (k1 * x) + b1;
				
				
				Console.WriteLine($"{Math.Round(x, 4)}; {Math.Round(y, 4)}");
				
			}
			
			catch (FormatException)
			{
				Console.WriteLine("Введен некорректный символ");
				Main();
			}
		}
	}
}