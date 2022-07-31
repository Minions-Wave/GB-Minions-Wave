namespace Seminar9
{
    class Ackerman
    {
        private static uint firstValue = 0;
        private static uint secondValue = 0;

        public static uint FirstValue
        {
            get { return firstValue; }
            set
            {
                if (value < 4) firstValue = value;
                else
                {
                    firstValue = 3;
                    Console.Write($"\n\tЗа значение первой переменной принято число: {firstValue}");
                }
            }
        }

        public static uint SecondValue
        {
            get { return secondValue; }
            set
            {
                if (value < 10) secondValue = value;
                else
                {
                    secondValue = 10;
                    Console.Write($"\n\tЗа значение второй переменной принято число: {secondValue}\n");
                }
            }
        }

        public static void FillDataForAckerman()
        {
            Console.Write("\n\tПожалуйста введите значение первой переменной\n" +
                "\tв виде натурального числа: ");
            string? startDigit = String.Empty;
            startDigit = Console.ReadLine();
            Console.Write(
                "\n\tПожалуйста введите значение второй переменной\n"
                    + "\tв виде натурального числа: "
            );
            string? endDigit = String.Empty;
            endDigit = Console.ReadLine();
            if (!String.IsNullOrEmpty(startDigit)
                && !String.IsNullOrEmpty(endDigit))
            {
                uint startValue = Convert.ToUInt16(startDigit.ToString());
                uint endValue = Convert.ToUInt16(endDigit.ToString());
                FirstValue = startValue;
                SecondValue = endValue;
            }
            else
            {
                FirstValue = 0;
                SecondValue = 0;
                Console.Write("\n\tВаш ввод не соответствует требованиям!\n" +
                        $"\tЗа значение первой переменной принято число: {FirstValue}");
                Console.Write($"\n\tЗа значение второй переменной принято число: {SecondValue}");
            }
        }
        public static uint AckermanFunction(uint n, uint m)
        {
            if (n == 0)
                return m + 1;
            else
              if ((n != 0) && (m == 0))
                return AckermanFunction(n - 1, 1);
            else
                return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
        }
    }
}
