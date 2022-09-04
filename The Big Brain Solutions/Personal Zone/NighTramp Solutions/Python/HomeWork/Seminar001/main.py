import os
import lib
import task_1
import task_2
import task_3
import task_4
import task_5
import task_6

def print_menu():
    clear = lambda: os.system('cls')
    clear()
    print('Домашние задание: Семинар 1')
    print('Выберите задачу:\n'+
          '1 - Это выходной?\n'+
          '2 - Проверка истинности предикат\n'+
          '3 - Определение четверти по координатам\n'+
          '4 - Димпазан координат по четверти\n'+
          '5 - Расстояние между 2 точками(2D)\n'+
          'Дополнительные:\n'+
          '6 - Числа Фибоначчи\n'+
          '===================\n'+
          '0 - Выход')

def menu():
    print_menu()
    flag = -1
    while flag != 0:
        flag = lib.input_number('Выберите задание: ',False,0,6)
        match flag:
            case 1:
                task_1.start_task()
            case 2:
                task_2.start_task()
            case 3:
                task_3.start_task()
            case 4:
                task_4.start_task()
            case 5:
                task_5.start_task()
            case 6:
                task_6.start_task()
                
menu()
