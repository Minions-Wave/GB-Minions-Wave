namespace Geekbrains
{
    public class Task58
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
                int[,] curArray1 = arr.CreateArrayInt(curArraySize[0], curArraySize[1], _startArray, _endArray);
                print.GeneratedArray();
                arr.PrintArray(curArray1);
                Console.WriteLine();
                int[,] curArray2 = arr.CreateArrayInt(curArraySize[0], curArraySize[1], _startArray, _endArray);
                arr.PrintArray(curArray2);
                print.GeneratedArray();
                Console.WriteLine();
                //print.TextWait();
                for (int i = 0; i < curArraySize[0]; i++)
                {

                    for (int j = 0; j < curArraySize[1]; j++)
                    {
                        curArray1[i, j] *= curArray2[i, j];
                    }

                }
                print.ResultedArray();
                arr.PrintArray(curArray1);
                print.TextWait();
            }

            else
            {
                Solution(print);
            }
        }
    }
}