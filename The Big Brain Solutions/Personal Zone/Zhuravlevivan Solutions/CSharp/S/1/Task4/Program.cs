// Напишите программу, которая на вход принимает число (N)
// а на выходе показывает все чётные числа от 1 до N. (не включая N) 

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < a)
{   
    if ((count % 2) == 0)
    
    Console.WriteLine($"{count} ");
    count++;
}
