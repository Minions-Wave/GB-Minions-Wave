// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите сколько будет всего чисел, для определения из них максимального и минимального: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
double[] array = new double[lastNumber];
int index = 0;
int lengthOfArray = array.Length;
Console.Write($"Введите {index + 1} целое число: ");
array[index] = Convert.ToDouble(Console.ReadLine());
double maxNumber = array[index];
double minNumber = array[index];
index++;
while (index < lengthOfArray)
{
    Console.Write($"Введите {index + 1} целое число: ");
    array[index] = Convert.ToDouble(Console.ReadLine());
    if (maxNumber < array[index]) maxNumber = array[index];
    if (minNumber > array[index]) minNumber = array[index];
    index++;
}
Console.WriteLine($"Максимальное число в Вашем ряду составляет {maxNumber}");
Console.Write($"Минимальное число в Вашем ряду составляет {minNumber}");
