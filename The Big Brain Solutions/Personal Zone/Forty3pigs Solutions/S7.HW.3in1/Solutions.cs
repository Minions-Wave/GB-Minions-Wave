namespace Geekbrains
{
    public class Task47
    {
        private string invitationParam = "size of array";
        private int startArray = -1000;
        private int endArray = 1000;
        public void Solution()
        {
            TaskText.InputInvitation(invitationParam);
            InputProcessing inp = new InputProcessing();
            string? size = Console.ReadLine();
            if (inp.InputCheck(size) != inp.errorMsgNull)
            {
                int[] curArraySize = inp.ConvertToInt(inp.SplitInput(size)); // Как упростить эту запись?
                // при размере [число, 0] отрисовывает пустой массив по кол-ву строк.
                if (curArraySize.Length == 2 && curArraySize[0] != 0 && curArraySize[1] != 0)
                {
                    Arrays arr = new Arrays();
                    arr.PrintArray(arr.CreateArray(curArraySize[0], curArraySize[1], startArray, endArray));
                    TaskText.TextWait();
                }
                else
                {
                    Console.WriteLine(inp.errorMsgSize);
                    TaskText.TextWait();
                    return;
                }
            }
        }
    }
    public class Task50
    {
        private string invitationParam = "element position";
        private int startArray = -1000;
        private int endArray = 1000;
        private int minArraySize = 4;
        private int maxArraySize = 12;

        public void Solution()
        {
            TaskText.InputInvitation(invitationParam);
            InputProcessing inp = new InputProcessing();
            string? position = Console.ReadLine();
            if (inp.InputCheck(position) != inp.errorMsgNull)
            {
                int[] elemPos = inp.ConvertToInt(inp.SplitInput(position)); // Как упростить эту запись?
                if (elemPos.Length == 2)
                {
                    Arrays arr = new Arrays();
                    Random rand = new Random();
                    double[,] curArray = arr.CreateArray(rand.Next(minArraySize, maxArraySize + 1),
                                                         rand.Next(minArraySize, maxArraySize + 1),
                                                         startArray, endArray);
                    arr.PrintArray(curArray);
                    if (elemPos[0] < curArray.GetLength(0) && elemPos[1] < curArray.GetLength(1))
                    {
                        Console.WriteLine($"\nElement in {elemPos[0]},{elemPos[1]} position is " +
                                          string.Format("{0,5:N2} ", curArray[elemPos[0], elemPos[1]]));
                    }
                    else
                    {
                        Console.WriteLine($"\nElement in {elemPos[0]},{elemPos[1]} position is absent");
                    }
                    TaskText.TextWait();
                }
                else
                {
                    Console.WriteLine(inp.errorMsgSize);
                    return;
                }
            }
        }
    }
    public class Task52
    {
        private int startArray = 0;
        private int endArray = 100;
        private int minArraySize = 4;
        private int maxArraySize = 10;
        public void Solution()
        {
            Arrays arr = new Arrays();
            Random rand = new Random();
            int[,] curArray = arr.CreateArrayInt(rand.Next(minArraySize, maxArraySize),
                                                 rand.Next(minArraySize, maxArraySize),
                                                 startArray, endArray);
            arr.PrintArray(curArray);
            Console.WriteLine(new string('=', curArray.GetLength(1) * 8 + 8));
            Console.Write("Average:");
            double result = 0.0;
            // Console.Write("\t");
            for (int j = 0; j < curArray.GetLength(1); j++)
            {
                for (int i = 0; i < curArray.GetLength(0); i++)
                {
                    result += curArray[i, j];

                }
                Console.Write(string.Format("{0,7:N2} ", result / curArray.GetLength(0)));
                result = 0.0;     // обнуляем result для нового столбца
            }
            Console.WriteLine();
            TaskText.TextWait();
        }
    }
}
