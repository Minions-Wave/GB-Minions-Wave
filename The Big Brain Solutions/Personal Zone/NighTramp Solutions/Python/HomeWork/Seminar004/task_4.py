import random

def write_file(st):
    with open('task_4.txt', 'w') as data:
        data.write(st)

def create_mnog(k):
    lst = [random.randint(0,101) for i in range(k+1)]
    return lst

def create_str(sp):
    lst= sp[::-1]
    wr = ''
    if len(lst) < 1:
        wr = 'x = 0'
    else:
        for i in range(len(lst)):
            if i != len(lst) - 1 and lst[i] != 0 and i != len(lst) - 2:
                wr += f'{lst[i]}x^{len(lst)-i-1}'
                if lst[i+1] != 0:
                    wr += ' + '
            elif i == len(lst) - 2 and lst[i] != 0:
                wr += f'{lst[i]}x'
                if lst[i+1] != 0:
                    wr += ' + '
            elif i == len(lst) - 1 and lst[i] != 0:
                wr += f'{lst[i]} = 0'
            elif i == len(lst) - 1 and lst[i] == 0:
                wr += ' = 0'
    return wr

def start_task():
    print('\nЗадача 4:\n' +
          'Задана натуральная степень k. Сформировать '+
          'случайным образом список коэффициентов '+
          '(значения от 0 до 100) многочлена и записать '+
          'в файл многочлен степени k.')
    write_file(create_str(create_mnog(int(input("Введите натуральную степень k = ")))))
    
start_task()
