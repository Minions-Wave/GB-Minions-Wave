using GBhomework6;

namespace GBhomework6
{
    class Structure
    {
        public int choice;

        Text task41 = new();
        Methods method = new();
        Text task43 = new();
        Program program = new();
        
        public int count;

        public void GetChoice(int n)
        {
            try
            {
                if (n == 1)
                {
                    task41.task1main();
                    method.str = Console.ReadLine();
                    method.GetArrayFromString(method.str);
                    method.PrintArray(method.GetArrayFromString(method.str));
                    count = method.GetCount(method.GetArrayFromString(method.str)); 
                    Console.WriteLine();
                    task41.task1result(count); 
                }
                else
                {
                    if (n == 2)
                    {
                        task43.task2main();
                        task43.task2k1();
                        method.k1 = Convert.ToInt32(Console.ReadLine());
                        task43.task2b1();
                        method.b1 = Convert.ToInt32(Console.ReadLine());
                        task43.task2k2();
                        method.k2 = Convert.ToInt32(Console.ReadLine());
                        task43.task2b2();
                        method.b2 = Convert.ToInt32(Console.ReadLine());
                        task43.task2result(method.GetCommonPoint(method.k1, method.b1, method.k2, method.b2));

                    }
                }
                if (n != 2 && n != 1)
                {
                    Text mistake = new();
                    mistake.mistake();
                    choice = Convert.ToInt32(Console.ReadLine());
                    GetChoice(choice);
                }
            }
            catch (System.Exception)
            {
                Text mistake = new();
                mistake.mistake();
                choice = Convert.ToInt32(Console.ReadLine());
                GetChoice(choice);
            }
        }

    }
}