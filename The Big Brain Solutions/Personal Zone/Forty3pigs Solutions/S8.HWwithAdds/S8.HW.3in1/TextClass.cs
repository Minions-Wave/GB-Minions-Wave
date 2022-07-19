namespace Geekbrains
{
    public class TextAndMessage
    {
        public void TaskList()
        {
            this.Text54();
            this.Text56();
            this.Text58();
        }
        public void PrintIntro()
        {
            TaskList();
            Console.WriteLine(_intro);
        }

        public void Text54() { Console.WriteLine(_text54); }

        public void Text56() { Console.WriteLine(_text56); }

        public void Text58() { Console.WriteLine(_text58); }
        public void ErrorEmptyInput() { Console.WriteLine(_errorMsgNull); }
        public void ErrorArraySize() { Console.WriteLine(_errorMsgSize); }
        public void GeneratedArray() { Console.WriteLine(_generatedArray); }
        public void ResultedArray() { Console.WriteLine(_resultedArray); }
        public void TextWait()
        {
            Console.WriteLine(_wait);
            Console.ReadKey();
        }
        public void InputInvitation(string parameters)
        {
            Console.WriteLine(_caution);
            Console.Write($"\nEnter the {parameters} separated by a space or semicolon: ");
        }
        public void minRowSum(int row) { Console.WriteLine($"The sum of the values in {row} row is minimal"); }
        private string _intro = "\nPress:     \x11 1 \x10  for start Task 54" +
                                "\n \t   \x11 2 \x10  for start Task 56" +
                                "\n \t   \x11 3 \x10  for start Task 58" +
                                "\n\n\t\x11 Escape \x10  for quit\n";
        private string _text54 = "\nЗадача 54: Задайте двумерный массив. Напишите программу, которая " +
                                 "упорядочит по возрастанию элементы каждой строки двумерного массива.";
        private string _text56 = "\nЗадача 56: Задайте прямоугольный двумерный массив. Напишите программу, " +
                                 "которая будет находить строку с наименьшей суммой элементов. ";
        private string _text58 = "\nЗадача 58: Задайте две матрицы. Напишите программу, которая будет " +
                                 "находить произведение двух матриц. ";
        private string _wait = "\nДля продолжения нажмите любую клавишу";
        private string _caution = "\n Caution: \nAll non numeric simbols will be equal to 0 \n" +
                                  "All negative numbers will be positive";
        private string _errorMsgNull = "Error. Array size is null or empty";
        private string _errorMsgSize = "Error. Array size problem";
        private string _generatedArray = "Generated array:";
        private string _resultedArray = "Resulted array:";
    }
}