from tkinter.tix import Tree
import lib

def sum_of_range(n):
    sum = 0
    for i in range(1,n+1): sum += i
    print(f'Ответ: {sum}\n')

def start_task():
    print('\nЗадача 2: Сумма\n' +
          'Требуется посчитать сумму целых чисел, '+
          'расположенных между числами 1 и N включительно.')
    sum_of_range(lib.input_number('Введите число: ',True))

# start_task()
