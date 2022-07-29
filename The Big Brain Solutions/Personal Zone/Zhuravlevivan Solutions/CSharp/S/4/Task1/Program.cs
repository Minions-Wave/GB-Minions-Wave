// // 1. Напишите программу, которая принимает на вход число N
// // и выдаёт произведение чисел от 1 до N.
// // 4 -> 24
// // 5 -> 120 

namespace Seminar_4
{
    class Program
    {
        public static void Main()
        {
        
        Console.Write("Введите число: ");
        
        int digit = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for(int i = 2; i <= digit; i++)
        {
            fact *= i;
            
        }  
        Console.Write($"Факториал числа {digit} равен {fact}");

        }

    }
}

// class Program {
//  public static int Main() {
//   Console.Write("Введите число : ");
//   int num = int.Parse(Console.ReadLine());
//   int factorial=1;
//   for(int i=1; i<=num; i++) {
//    factorial*=i;
//    if(i==num) {
//     Console.Write("{0}", i);
//    }
//    else {
//     Console.Write("{0} * ", i);
//    }
//   }
//   Console.Write(" = {0}", factorial);
//   Console.ReadKey();
//   return 0;
//  }
// }