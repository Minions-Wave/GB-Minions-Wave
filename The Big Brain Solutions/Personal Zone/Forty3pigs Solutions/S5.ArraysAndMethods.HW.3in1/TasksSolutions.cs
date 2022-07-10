namespace Geekbrains
{
    public class Tasks
    {
        public void solution34()
        {
            int size = Arrays.AskSize();
            int digitCapacity = AskDigitCapasity();
            int[] array = new Arrays().CreateArray(size, digitCapacity);
            EvenCount(array);

        }
        public void solution36()
        {
            int size = Arrays.AskSize();
            int[] array = new Arrays().CreateArray(size);
            InOddsSum(array);

        }
        public void solution38()
        {
            bool isDouble = true;
            int size = Arrays.AskSize();
            double[] array = new Arrays().CreateArray(size, isDouble);
            MinMaxDiff(array);

        }
        static public int AskDigitCapasity()
        {
            Console.Write("Enter digit capacity: ");
            int.TryParse(Console.ReadLine(), out int DC);
            return DC;
        }
        static public void EvenCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }
            Console.WriteLine($"\nEvens quantity in this array = {count} \n");
        }

        static public void InOddsSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) sum += array[i];
            }
            Console.WriteLine($"\nSum of the odds positions = {sum} \n");
        }

        public void MinMaxDiff(double[] array)
        {
            double min = array[0];
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];

            }
            Console.WriteLine($"\nThe difference between Max({max}) and Min({min}) = {(max - min)} \n");
        }
    }

}

