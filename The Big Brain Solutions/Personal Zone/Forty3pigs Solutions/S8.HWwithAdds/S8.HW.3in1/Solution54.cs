namespace Geekbrains
{
    public class Task54
    {
        private string _invParam = "size of array";
        private int _startArray = -9;
        private int _endArray = 10;
        public void Solution(TextAndMessage print)
        {
            print.InputInvitation(_invParam);
            string? strArraySize = Console.ReadLine();
            InputProcessing inp = new InputProcessing();
            int[] curArraySize = inp.GetSizes(strArraySize);
            if (inp.InputValidation(strArraySize, curArraySize, print))
            {
                Arrays arr = new Arrays();
                int[,] curArray = arr.CreateArrayInt(curArraySize[0], curArraySize[1], _startArray, _endArray);
                arr.PrintArray(curArray);
                Console.WriteLine();
                //print.TextWait();
                for (int i = 0; i < curArray.GetLength(0); i++)
                {
                    int[] tmp = new int[curArray.GetLength(1)];
                    for (int j = 0; j < curArray.GetLength(1); j++)
                    {
                        tmp[j] = curArray[i, j];
                    }
                    Array.Sort(tmp);
                    for (int j = 0; j < curArray.GetLength(1); j++)
                    {
                        curArray[i, j] = tmp[j];
                    }
                }
                arr.PrintArray(curArray);
                print.TextWait();
            }

            else
            {
                Solution(print);
            }
        }
    }
}