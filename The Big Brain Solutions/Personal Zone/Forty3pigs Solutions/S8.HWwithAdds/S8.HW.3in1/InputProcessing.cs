namespace Geekbrains
{
    ///<include file='info.xml' path='docs/InputProcessing/helps[@name="InputProcessing"]/*'/>
    public class InputProcessing
    {
        ///<include file='info.xml' path='docs/InputValidation/helps[@name="InputValidation"]/*'/>
        public bool InputValidation(string? strForValidation, int[] sizes, TextAndMessage print)
        {
            if (!String.IsNullOrEmpty(strForValidation))
            {

                if (sizes.Length == 2 && sizes[0] > 0 && sizes[1] > 0)
                {
                    return true;
                }
                else
                {
                    print.ErrorArraySize();
                    print.TextWait();
                    return false;
                }
            }
            else
            {
                print.ErrorEmptyInput();
                print.TextWait();
                return false;
            }
        }
        ///<include file='info.xml' path='docs/InputValidation/helps[@name="InputValidation"]/*'/>
        public bool InputValidation(string? strForValidation, TextAndMessage print)
        {
            if (!String.IsNullOrEmpty(strForValidation))
            {
                return true;
            }
            else
            {
                print.ErrorArraySize();
                print.TextWait();
                return false;
            }
        }
        ///<include file='info.xml' path='docs/GetSizes/helps[@name="GetSizes"]/*'/>
        public int[] GetSizes(string inputString)
        {
            int[] sizes = this.ConvertToInt(this.SplitInput(inputString));
            return sizes;
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
        ///<include file='info.xml' path='docs/SplitInput/helps[@name="SplitInput"]/*'/>
        public string[] SplitInput(string inputStr)
        {
            // Убираем лишнее, оставляем разделение размеров через ;
            inputStr = inputStr.Trim()
                               .Replace(" ; ", ";")
                               .Replace(" ;", ";")
                               .Replace("; ", ";")
                               .Replace(" ", ";");

            string[] splitedStr = inputStr.Split(';'); // делим строку по разделителю ;
            return splitedStr;
        }
    }
}
