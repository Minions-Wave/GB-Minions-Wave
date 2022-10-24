import entity.Person;

import com.fasterxml.jackson.databind.ObjectMapper;

import java.io.IOException;
import java.lang.reflect.Field;
import java.nio.file.Paths;
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

        log.info(String.format("\nЕсть запрос '%s'\n",sb.getValue()));
        
        log.info("Добавляем условие из 2 массивов");
        log.info(String.format("Получим '%s'\n", sb.addWhere(paramName, paramValue)));
        
        sb.setDefault();
        
        log.info("Добавляем условие из json файла.");
        log.info(String.format("Получим '%s'", sb.addWhereFromJSON("test.json")));
        
    }
}

/**
 * SQLBuilder
 */
class SQLBuilder {

    private Logger log = Logger.getLogger(SQLBuilder.class.getName());
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
    public String addWhereFromJSON(String path) {
        
        StringBuilder sb = new StringBuilder(str);
        try {
            ObjectMapper mapper = new ObjectMapper();
            Person temp = mapper.readValue(Paths.get(path).toFile(), Person.class);
            
            sb.append(" where ");

            for(Field field : temp.getClass().getDeclaredFields()) {
                sb.append(field.getName()).append(" = '").append(temp.get(field.getName()));
                sb.append("' and ");
            }
        } catch (IOException e) {
            log.info(e.toString());
        }
        
        this.str = sb.substring(0, sb.length() - 6);
        return this.str;
    }
}

