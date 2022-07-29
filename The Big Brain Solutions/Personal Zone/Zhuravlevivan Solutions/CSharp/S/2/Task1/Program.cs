/*
Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому.
Если второе число не кратно числу первому,
то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

namespace GeekBrains
{
    class Program{
        public static void Main(string[] args)
        {
        
        Console.Write("Input first digit: ");
        int d1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input second digit: ");
        int d2 = Convert.ToInt32(Console.ReadLine());

        int max = d1,
            min = d2;
        int ost = max % min;
        if(d2 > d1)
        {
            max = d2;
            min = d1;
        }

        if(max % min == 0)
        {
            Console.WriteLine($"{max} кратно {min}");
        }
        if(max % min > 0)
        {
            Console.WriteLine($"{max} Не кратно {min}, остаток - {ost}");
        }
        }

    }
}
