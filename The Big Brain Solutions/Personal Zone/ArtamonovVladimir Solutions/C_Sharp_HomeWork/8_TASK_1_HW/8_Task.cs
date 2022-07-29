// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое положительное число, до которого будет определяться все четные числа от 1: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
// Не используем пока:
//int[] array = new int[lastNumber];
//int index = 0;
//int lengthOfArray = array.Length;
int number = 0;
Console.Write($"Четные числа в ряду от 1 до {lastNumber}: ");
while (number < lastNumber)
{
    number++;
    if (number % 2 == 0) Console.Write($"{number}, ");
}
