namespace Geekbrains
{
    public class Task43
    {
        public void Solution()
        {
            Console.WriteLine("\nEnter the values b1, k1, b2, and k2 sequentially:\n");
            double[,] a = FillTable();
            if (a[0, 0] == a[1, 0])
            {
                Console.WriteLine("\nIt's parallel");
            }
            else
            {
                double x = (a[1, 0] - a[0, 0]) / (a[0, 1] - a[1, 1]);
                double y = a[0, 1] * x + a[0, 0];
                Console.WriteLine($"\nCoordinates of the intersection point is ({x}; {y})\n");
            }

        }
        public double[,] FillTable()
        {
            double[,] arr = new double[2, 2];
            Console.WriteLine("!!!WARNING!!!\nAll non numerics will equal to 0 ");
            Console.Write("\nEnter b1: ");
            double.TryParse(Console.ReadLine(), out arr[0, 0]); //b1
            Console.Write("Enter k1: ");
            double.TryParse(Console.ReadLine(), out arr[0, 1]); //k1
            Console.Write("Enter b2: ");
            double.TryParse(Console.ReadLine(), out arr[1, 0]); //b2
            Console.Write("Enter k2: ");
            double.TryParse(Console.ReadLine(), out arr[1, 1]); //k2

            return arr;
        }
    }
}