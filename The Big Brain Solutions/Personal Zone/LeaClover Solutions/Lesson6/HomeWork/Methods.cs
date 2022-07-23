using GBhomework6;

namespace GBhomework6
{
    class Methods
    {
        public string? str;

        public double k1;
        public double k2;
        public double b1;
        public double b2;

        public double x;
        public double y;

        public int[] GetArrayFromString(string str)
        {
            int[] arrayS = Array.ConvertAll(str.Split(' '), int.Parse);
            return arrayS;
        }

        public int[] PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " | ");
            }
            return array;
        }

        public double[] PrintArrayD(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " | ");
            }
            return array;
        }


        public int GetCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public double[] GetCommonPoint(double k1, double b1, double k2, double b2)
        {
            double[] array = new double[2];
            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;
            array[0] = x;
            array[1] = y;
            return array;

        }
    }
}