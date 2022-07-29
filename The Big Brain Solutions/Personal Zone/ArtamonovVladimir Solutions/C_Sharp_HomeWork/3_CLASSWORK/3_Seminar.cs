namespace VladimirArtamnov
 {
    class Seminar_3_Task_1
    {
        //Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
        // 2|1
        // 3|4
        
        public static int GetRandomNumber(int first, int second)
        {
            int randomNumber = new Random().Next(first, second);
            return randomNumber;
        }
        
        public static void Main(string[] args)
        {
            int x = GetRandomNumber(int.MinValue,int.MaxValue);
            int y = GetRandomNumber(int.MinValue,int.MaxValue);
            //x = 0;
            //y = 0;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            if (x == 0 || y == 0)
            {
                Console.WriteLine($"Координаты X {x} и/или Y {y} равны нулю");
            }
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Координаты X {x} и Y {y} находится в Первой четверти");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine($"Координаты X {x} и Y {y} находится в Второй четверти");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine($"Координаты X {x} и Y {y} находится в Третей четверти");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine($"Координаты X {x} и Y {y} находится в Четвертая четверть");
            }

        }
    }
 }
// namespace VladimirArtamnov
//  {
//     class Seminar_3_Task_2
//     {
//         //Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//         // 2|1
//         // 3|4
        
//         public static int GetRandomNumber(int first, int second)
//         {
//             int randomNumber = new Random().Next(first, second);
//             return randomNumber;
//         }
        
//         public static void Main(string[] args)
//         {
//             int coord = GetRandomNumber(1,5);
//             Console.Write($"Четверть равна {coord} это: ");
//             if (coord == 1)
//             {
//                 Console.WriteLine($"Координаты X от 0 до {int.MaxValue} и Y от 0 до {int.MaxValue}");
//             }
//             if (coord == 2)
//             {
//                 Console.WriteLine($"Координаты X от 0 до {int.MinValue} и Y от 0 до {int.MaxValue}");
//             }
//             if (coord == 3)
//             {
//                 Console.WriteLine($"Координаты X от 0 до {int.MinValue} и Y от 0 до {int.MinValue}");
//             }
//             if (coord == 4)
//             {
//                 Console.WriteLine($"Координаты X от 0 до {int.MaxValue} и Y от 0 до {int.MinValue}");
//             }

//         }
//     }
//  }