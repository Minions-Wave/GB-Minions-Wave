namespace Task
{
    class Decisions
    {
        public int GetQuantityEven(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    count++;
            }
            return count;
        }

        public int GetSumOfOddPositions(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                    result = result + array[i];
            }
            return result;
        }

        public double[] CreateManualArray()
        {
            Console.Write("Пожалйста введите размер массива: ");
            int length = 0;
            string? sizeOfArray = Console.ReadLine();
                    if (!String.IsNullOrEmpty(sizeOfArray))
                        length = Convert.ToInt32(sizeOfArray.ToString());
                    Console.WriteLine();

            double[] result = new double[length];
            int i = 0;
            while (i < length)
            {
                try
                {
                    Console.Write($"Пожалуйста введите вещественное число для элемента с идексом {i}: ");
                    string? element = Console.ReadLine();
                    if (!String.IsNullOrEmpty(element))
                    {
                        result[i] = Convert.ToDouble(element.ToString());
                        i++;
                    }
                }
                catch
                {
                    Console.WriteLine("Проверьте ввод, он не корректный!");
                    continue;
                }
            }
            return result;
        }

        public double DiffMaxMinElements(double[] array)
        {
            double maxElement = array[0];
            double minElement = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                    maxElement = array[i];
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minElement)
                    minElement = array[i];
            }
            return maxElement - minElement;
        }
    }
}
