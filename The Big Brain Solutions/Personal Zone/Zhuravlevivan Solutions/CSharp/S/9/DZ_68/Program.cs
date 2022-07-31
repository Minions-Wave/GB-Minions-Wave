// Задача 68: Напишите программу вычисления
// функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29
namespace DZ_64
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("\nФункция Аккермана для M и N");
            Console.Write("\nЗадайте M: ");
            uint m = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Задайте N: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine();
            FuncAkkerman(m, n);
            Console.WriteLine(FuncAkkerman(m, n));


        }
        public static uint FuncAkkerman(uint a, uint b)
        {
            if (a == 0)
            {
                return b + 1;
            }
            else if ((a != 0) && (b == 0))
            {
                return FuncAkkerman(a - 1, 1);
            }
            else
            {
                return FuncAkkerman(a - 1, FuncAkkerman(a, b - 1));
            }
        }
    }
}