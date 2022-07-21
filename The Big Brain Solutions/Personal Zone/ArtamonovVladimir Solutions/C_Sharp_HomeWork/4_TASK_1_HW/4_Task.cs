// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите сколько будет всего чисел, для опледеления из них максимального: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
double[] array = new double[lastNumber];
int index = 0;
double maxNumber = 0;
int lengthOfArray = array.Length;
while (index < lengthOfArray)
{
    Console.Write($"Введите {index + 1} целое число: ");
    array[index] = Convert.ToDouble(Console.ReadLine());
    if (maxNumber < array[index]) maxNumber = array[index];
    index++;
}
Console.Write($"Максимальное число в Вашем ряду составляет {maxNumber}");
