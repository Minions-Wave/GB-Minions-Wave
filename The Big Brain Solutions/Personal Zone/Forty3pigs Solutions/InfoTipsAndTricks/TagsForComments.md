## Тег  Используется для
***
```
<c>	одна строка исходного кода

<code>	много строк исходного кода

<example>	пример использования, можно использовать совместно с тегом <code>

<exception>	позволяет указать, какие исключения наш метод может выдавать

<include>	позволяет поставить ссылку на файл, в котором содержаться комментарии, используя XPath

<list>	обычный список

<para>	а это обычный параграф

<param>	описания параметра метода, каждый параметр описывается отдельно

<paramref>	позволяет указать, что слово внутри тега является параметром

<permission>	позволяет описать права доступа к методу

<remarks>	дополнительная информация, помимо тега <summary>

<returns>	описание того, что метод возвращает

<see>	позволяет указывать ссылки

<seealso>	текст в секции «Смотри также»

<summary>	общее описание

<value>	позволяет описывать свойства
```


### Example

```
/// <summary>
/// Этот метод передаёт привет ХабраХабру столько раз, сколько скажите.
/// </summary>
/// <param name="repeat">Сколько раз передать привет</param>
/// <returns>Сама строка с приветами</returns>
public string HelloHabr(int repeat)
{
     string result = "";
     for (int i = 0; i < repeat; i++)
     {
         result += "Hello, HabraHabr!\n";
     }
     return result;
}
```
***

## Для активации XML-доков надо в csproj добавить
```
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <DocumentationFile>include.xml</DocumentationFile>
    <!--  <NoWarn>$(NoWarn);1591</NoWarn> -->
```

закомментированное - отключение какого-то оповещения, надо тестить.

## Пример использования XML
```
// Divides an integer by another and returns the result
/// <include file='include.xml' path='docs/members[@name="math"]/divideInt/*'/>

        public static int Divide(int a, int b)
        {
            return a / b;
        }

// Divides a double by another and returns the result
/// <include file='include.xml' path='docs/members[@name="math"]/DivideDouble/*'/>

        public static double Divide(double a, double b)
        {
            return a / b;
        }
```
### Include file location:
CommentsForCodeXML\CExampleForMathClass_bad\include.xml