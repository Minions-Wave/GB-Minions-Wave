namespace GeekBrains
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Введите : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] squares = GetSquare(a);

            for (int i = 0; i < squares.Length; i++)
            {
                Console.WriteLine( squares[i] + "");
            }

        }

        public static int[] GetSquare(int n)
        {
            int[] square = new int[n];
            for (int i = 1; i <= n; i++)
            {
                square[i-1] = i * i;
            }
            return square;
        }
        
    }
}