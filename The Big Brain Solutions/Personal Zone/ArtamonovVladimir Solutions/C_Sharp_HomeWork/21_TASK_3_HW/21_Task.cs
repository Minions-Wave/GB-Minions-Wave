namespace VladimirArtamnov
 {
    class HomeWork_Task_21
    {
        //Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        //A (3,6,8); B (2,1,-7), -> 15.84
        //A (7,-5, 0); B (1,-1,9) -> 11.53
        
        // public static int GetRandomNumber(int first, int second)
        // {
        //     int randomNumber = new Random().Next(first, second);
        //     return randomNumber;
        // }

        public static void GetIntputArray(double[] massive_A, double[] massive_B)
        {
            int lastI = massive_A.Length;
            int i = 0;
            for (i = 0; i < lastI; i++)
            {
            Console.WriteLine($"Введите {i+1} Координату из X,Y,Z для заполнения точки A: ");
            massive_A[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите {i+1} Координату из X,Y,Z для заполнения точки B: ");
            massive_B[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static double distanceCalc3D(double[] col_A, double[] col_B)
        {
            int lastIndex = col_A.Length;
            int i = 0;
            double pointCalc = 0;
            for (i = 0; i < lastIndex; i++)
            {
                pointCalc = pointCalc + Math.Pow(col_B[i] - col_A[i], 2);
            }
            Console.WriteLine(pointCalc);
            return pointCalc;
        }
        
        public static void Main(string[] args)
        {
            int number = 3;
            //double pointCalc = 0;
            double[] pointA = new double[number];
            double[] pointB = new double[number];
            GetIntputArray(pointA, pointB);
            //Console.WriteLine(pointCalc);
            double result = Math.Sqrt(distanceCalc3D(pointA, pointB));
            Console.WriteLine(result);

        }
    }
 }

