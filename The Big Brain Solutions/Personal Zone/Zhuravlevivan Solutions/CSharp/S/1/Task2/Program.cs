// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

// if ((a > b) && (a > c))
// Console.WriteLine($"Максимальное введенное число: {a}");
// if ((a > b) && (a < c))
// Console.WriteLine($"Максимальное введенное число: {c}");
// if ((a < b) && (b < c))
// Console.WriteLine($"Максимальное введенное число: {c}");
// if ((a < b) && (b > c))
// Console.WriteLine($"Максимальное введенное число: {b}");

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное введенное число: {max}");
