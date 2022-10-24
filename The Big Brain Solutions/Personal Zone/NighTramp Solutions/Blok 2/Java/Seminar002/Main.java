import java.util.logging.Logger;

// Дана строка sql-запроса "select * from students".
// Сформируйте часть WHERE этого запроса, используя StringBuilder.
//
// 1) Данные для фильтрации подаются в метод двумя массивами paramName и paramValue.
// 2) Данные для фильтрации подаются в метод строкой в формате json.
//      Пример json: {"firstName": "Ivan", "secondName": "Ivanov", ....}
// Результат работы методов: "select * from students where firstName = 'Ivan' and ...".

/**
 * Main
 */
public class Main {

    private static String[] paramName = new String[] {"firstName", "secondName"};
    private static String[] paramValue = new String[] {"Ivan", "Ivanov"};

    public static void main(String[] args) {
        Logger log = Logger.getLogger(Main.class.getName());

        SQLBuilder sb = new SQLBuilder();
        log.info(String.format("Есть запрос '%s'",sb.getValue()));
        log.info("Добавляем условие.");
        log.info(String.format("Получим '%s'", sb.addWhere(paramName, paramValue)));
    }
}

/**
 * SQLBuilder
 */
class SQLBuilder {

    private String str;

    SQLBuilder() {
        this.str = "select * from students";
    }
    public void setDefault() { this.str = "select * from students"; }
    public String getValue() { return this.str; }
    public String addWhere(String[] pN, String[] pV) {
        StringBuilder sb = new StringBuilder(str);
        sb.append(" where ");
        for (int i = 0; i < pN.length; i++) {
            sb.append(pN[i]).append(" = '").append(pV[i]);
            if (i < pN.length-1)
                sb.append("' and ");
        }
        this.str = String.valueOf(sb);
        return this.str;
    }
    
}