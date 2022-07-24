/*
Дополнительная задача
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
using System;
using System.Threading;

namespace Task62
{
    class Program
    {
        static int[,] baby = new int[0,0];
        static int round;
        static int round1;
        static int round2;
        static int turn;
        static bool WatchOutHereICome()
        {
            round1++;
            round2--;
            if (round1 <= round / 2) return true;
            else return false;

        }
        static void YouSpinMeRightRound(int[,] baby)
        {
            int i;
            if (turn == 1) i = round1;
            else i = round2;
            for (int j = round1; j < round2; j++)
            {
                if (turn == 1) baby[i,j] = 1;
                else baby[i,round-1-j] = 1;
                Console.Clear();
                ViewTwoDimensionalArray(baby);
                Thread.Sleep(450);
            }
        }
        static void RightRoundLikeARecord(int[,] baby)
        {
            int j;
            if (turn == 1) j = round2;
            else j = round1;
            for (int i = round1; i < round2; i++)
            {
                if (turn == 1) baby[i,j] = 1;
                else baby[round-1-i,j] = 1;
                Console.Clear();
                ViewTwoDimensionalArray(baby);
                Thread.Sleep(450);
            }
        }
        static void RightRoundRoundRound()
        {
            turn *= -1;
            if(round1 == round2) 
            {
                baby[round1,round2] = 1;
                Console.Clear();
                ViewTwoDimensionalArray(baby);
                Thread.Sleep(450);
            }
        }
        
        static void StartARecord()
        {
            do
            {
                YouSpinMeRightRound(baby);
                RightRoundLikeARecord(baby);
                RightRoundRoundRound();
                YouSpinMeRightRound(baby);
                RightRoundLikeARecord(baby);
                RightRoundRoundRound();   
            }
            while (WatchOutHereICome());            
        }
        static void ViewTwoDimensionalArray(int[,] array)
        {
            Console.WriteLine("Dead or Alive - You Spin me Right Round");
            Console.WriteLine("Playing!...");
            for (int i = 0; i <= array.GetUpperBound(0); i++) //row
            {
                Console.Write("[ ");
                for (int j = 0; j <= array.GetUpperBound(1); j++) //columns
                {
                    Console.Write("{0} ", array[i,j]);
                }
                Console.WriteLine("]");
            }
        }
        static void PlayingConfig()
        {
            Console.Write("Введите значение размера матрицы: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Recording...");
            baby = new int[size,size];
            round = baby.GetLength(0);
            round1 = 0;
            round2 = round-1;
            turn = 1;
        }
        static void Main(string[] asgs)
        {
            PlayingConfig();
            Console.Clear();
            StartARecord();
        }
    }
}