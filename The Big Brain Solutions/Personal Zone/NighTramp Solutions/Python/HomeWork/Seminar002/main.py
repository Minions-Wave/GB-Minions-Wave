import os
import lib
import task_1
import task_2
import task_3
import task_4

def print_menu():
    clear = lambda: os.system('cls')
    clear()
    print('Домашние задание: Семинар 2')
    print('Выберите задачу:\n'+
          '1 - Монетки\n'+
          '2 - Сумма\n'+
          '3 - Минимальный делитель\n'+
          '4 - Шеренга\n'+
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
                
menu()
