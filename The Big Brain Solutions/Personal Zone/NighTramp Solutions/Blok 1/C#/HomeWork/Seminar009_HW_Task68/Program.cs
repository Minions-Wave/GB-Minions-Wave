/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
namespace Task68
{
    class Program
    {
        static int AckermanF(int m, int n)
        {
            if (m == 0) return n + 1;
            else if ((m != 0) && (n == 0)) return AckermanF(m - 1, 1);
            else return AckermanF(m - 1, AckermanF(m, n - 1));
        }
        static void Main(string[] asgs)
        {
            Console.Write("Введите первое число: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int result = AckermanF(M, N);
            Console.WriteLine(result);
        }
    }
}