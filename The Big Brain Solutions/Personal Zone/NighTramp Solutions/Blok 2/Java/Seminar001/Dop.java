import java.util.Scanner;

/**
//На вход некоторому исполнителю подаётся два числа (a, b). У исполнителя есть две команды
//- команда 1 (к1): увеличить в с раза, а умножается на c
//- команда 2 (к2): увеличить на d ( +2 ), к a прибавляется d
//Написать программу, которая выдаёт массив команд, позволяющий число a превратить в число b или сообщить, что это невозможно
//Пример 1: а = 1, b = 7, c = 1, d = 3
//ответ: [к1, к1, к1, к1, к1, к1] или [к1, к2, к1, к1, к1] или [к1, к1, к2, к1].
//Пример 2: а = 11, b = 7, c = 2, d = 1
//ответ: [].
 */
public class Dop {
    public static void main(String[] args) {
        Task task = new Task();
        task.init();
        System.out.println("Возможные наборы команд:");
        int x = task.f(task.get_a(),"[");
        if (x == 0)
            System.out.println("[ Таких наборов не существует ]");
        System.out.printf("Количество наборов: %s", x);
    }
    
}

/**
 * task
 */
class Task {
    private int a, b, c, d = 0;

    public int f(int n, String s) {
        if (n == b){
            s = s + " ]";
            System.out.println(s);
            return 1;
        }   
        else if (n > b)
            return 0;
        else
            return f(n * c, s + " k1") + f(n + d, s + " k2");
    }
    
    public void init() {
        Scanner in = new Scanner(System.in);
        System.out.println("Ввод данных:");
        System.out.print("Введите число a: ");
        a = in.nextInt();
        System.out.print("Введите число b: ");
        b = in.nextInt();
        System.out.print("Введите число c: ");
        c = in.nextInt();
        System.out.print("Введите число d: ");
        d = in.nextInt();
        in.close();
    }
    public int get_a() {
        return a;
    }
}