using GBhomework7;

namespace GBhomework7
{
    class Structure
    {
        public int choice;

        Program program = new();

        public void GetChoice(int n)
        {
            try
            {
                if (n == 1)
                {
                    Task47 task47 = new();
                    task47.GetTask47();
                }
                else
                {
                    if (n == 2)
                    {
                        Task50 task50 = new();
                        task50.GetTask50();
                    }
                    else
                    {
                        if (n == 3)
                        {
                            Task52 task52 = new();
                            task52.GetTask52();
                        }
                    }
                }
                if (n != 2 && n != 1 && n!=3)
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