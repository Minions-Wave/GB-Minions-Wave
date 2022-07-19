
# Program blank
```

namespace Geekbrains
{
    static public class Homework
    {
        static public void Main(string[] args)
        {

        }
    }

}


```
### Text to Int32
```
                Console.WriteLine("All non numerics will be ignored ");
                Console.Write("Enter first number: ");
                int.TryParse(Console.ReadLine(), out int first);
```                

### Методы
```
// ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ...])
// {
//   ТелоМетода;
//   return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }
// Если без return, то вместо ВозвращаемыйТипДанных пишется void
```

### Проверка ввода консоли на то, что ввели число
---
```
while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.WriteLine("Вы ввели число {0}", number);
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
```
### Проверка строки посимвольно, что все символы цифровые
---
```
bool StringIsDigits(string s)
{
   foreach(var item in s)
   {
      if(!char.IsDigit(item))
         return false; //если хоть один символ не число, то выкидываешь "ложь"
   }
   return true; //если ни разу не выбило в цикле, значит, все символы - это цифры
}
```