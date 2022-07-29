using GBhomework7;

namespace GBhomework7
{
    class Program
    {
        public static void Main()
        {
            Text main = new();
            Structure choice = new();
            main.maintext();
            choice.choice = Convert.ToInt32(Console.ReadLine());
            choice.GetChoice(choice.choice);
        }
    }
}