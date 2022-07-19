namespace Geekbrains
{
    public class InputProcessing
    {
        public string errorMsgSize = "Error. Array size problem";
        public string errorMsgNull = "Error. Array size is null or empty";
        public string InputCheck(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                return str;
            }
            else return errorMsgNull;
        }
        public int[] ConvertToInt(string[] strToConvert)
        {
            int[] parameters = new int[strToConvert.Length];
            for (int i = 0; i < strToConvert.Length; i++)
            {
                int.TryParse(strToConvert[i], out int p);
                parameters[i] = Math.Abs(p);
            }
            return parameters;
        }
        public string[] SplitInput(string inputStr)
        {
            // Убираем лишнее, оставляем разделение размеров через ;
            inputStr = inputStr.Trim().Replace(" ; ", ";").Replace(" ;", ";").Replace("; ", ";").Replace(" ", ";");
            //Console.WriteLine(inputStr);             // отладочный вывод
            string[] splitedStr = inputStr.Split(';'); // делим строку по разделителю ;
            return splitedStr;
        }
    }
}
