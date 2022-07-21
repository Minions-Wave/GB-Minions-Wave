namespace Geekbrains
{
    public class Task56
    {
        private string _invParam = "size of array";
        private int _startArray = -9;
        private int _endArray = 10;
        public void Solution(TextAndMessage print)
        {
            print.InputInvitation(_invParam);
            string? strArraySize = Console.ReadLine();
            InputProcessing inp = new InputProcessing();
            if (inp.InputValidation(strArraySize, print))
            {
                try
                {
                    int curArraySize = Convert.ToInt32(strArraySize);

                    Arrays arr = new Arrays();
                    int[,] curArray = arr.CreateArrayInt(curArraySize, curArraySize, _startArray, _endArray);
                    arr.PrintArray(curArray);
                    Console.WriteLine();
                    //print.TextWait();
                    int result = Int32.MaxValue;
                    int stringNo = 0;
                    for (int i = 0; i < curArray.GetLength(0); i++)
                    {
                        int sum = 0;
                        for (int j = 0; j < curArray.GetLength(1); j++)
                        {
                            sum += curArray[i, j];
                        }
                        if (sum < result)
                        {
                            result = sum;
                            stringNo = i;
                        }
                    }
                    print.minRowSum(stringNo + 1);
                    print.TextWait();
                }

                catch
                {
                    print.ErrorArraySize();
                    Solution(print);
                }

            }

            else { Solution(print); }

        }
    }
}