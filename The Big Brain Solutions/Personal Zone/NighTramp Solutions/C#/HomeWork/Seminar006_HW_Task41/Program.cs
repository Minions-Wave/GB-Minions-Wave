/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
namespace Task41
{
    class Program
    {    
        static int[] FillArray()
        {
            int[] array = new int[0];
            for (int i = 0; i < 1; i++)
            {
                if (Int32.TryParse(Console.ReadLine(), out int temp)) 
                {
                    array = new int[temp];
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (Int32.TryParse(Console.ReadLine(), out temp)) 
                        {
                            array[j] = temp;
                        }
                        else
                        {
                            j--;
                        }
                    }
                }
                else
                {
                    i--;
                }
            }
            return array;
        }
        static void ViewArrayAndAmountOfNumbersGreaterThanZero(int[] array)
        {
            int amountNumbers = 0;
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) amountNumbers++;
                if (i != array.Length - 1)
                {
                    Console.Write("{0}, ", array[i]);
                }
                else
                {
                    Console.Write("{0}] -> {1}", array[i], amountNumbers);
                }
            }
        }
        static void Main(string[] asgs)
        {
            ViewArrayAndAmountOfNumbersGreaterThanZero(FillArray());

        }
    }
}