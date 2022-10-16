import java.util.Scanner;

/**
//Реализовать функцию возведения числа а в степень b. a, b – целые числа.
//
//Пример 1: а = 3, b = 2, ответ: 9
//Пример 2: а = 2, b = -2, ответ: 0.25
//Пример 3: а = 3, b = 0, ответ: 1
 */
public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int a, b;
        
        System.out.print("Введите число a: ");
        a = input.nextInt();
        System.out.print("Введите число b: ");
        b = input.nextInt();
        
        System.out.printf("Ответ: %s", Math.pow(a, b));
        input.close();
    }
}