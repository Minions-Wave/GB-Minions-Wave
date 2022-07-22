int[] array = { 1, 2, 33, 54, 51, 6, 7, 33, 8 };

int n = array.Length;
// Console.WriteLine(n);
int find = 33;

int index = 0;

// Console.WriteLine(array[find]);
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index +1;
}
