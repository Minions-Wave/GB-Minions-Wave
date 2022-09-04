namespace F3P
{
    public static class MySorts
    {
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
            return arr;
        }

        public static int[] ShakerSort(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                for (int i = right; i > left; i--)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = tmp;
                    }
                }
                ++left;
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
                --right;
            }
            return arr;
        }

        public static int[] CombSort(int[] arr)
        {
            double gap = arr.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < arr.Length)
                {
                    int igap = i + (int)gap;
                    if (arr[i] > arr[igap])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[igap];
                        arr[igap] = tmp;
                        swaps = true;
                    }
                    i++;
                }
            }
            return arr;
        }

        public static int[] InsertSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j;
                int cur = arr[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (arr[j] < cur)
                        break;

                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = cur;
            }
            return arr;
        }

        public static int[] ChoiseSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int tmp = arr[min];
                arr[min] = arr[i];
                arr[i] = tmp;
            }
            return arr;
        }

        public static int[] QuickSort(int[] arr)
        {
            return arr;
        }

        public static int[] MergeSort(int[] arr)
        {
            return arr;
        }

        public static int[] PyramidSort(int[] arr)
        {
            return arr;
        }

    }
}