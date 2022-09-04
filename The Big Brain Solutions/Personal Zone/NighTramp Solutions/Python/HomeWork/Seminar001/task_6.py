# Последовательностью Фибоначчи называется 
# последовательность чисел a0, a1, ..., an, ..., где
# a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1).
# Требуется найти N-е число Фибоначчи. N (0 ≤ N ≤ 30).

import lib

def find_Fibonachi():
    a = 0
    b = 1
    c = 0
    with open('input.txt','r') as f:
        n = int(f.readline())-1
        print(f'Прочитали из файла input.txt номер элемента: {n+1}')
        for i in range(n):
            c = b + a
            a = b
            b = c
        print(f'{n+1}й элемент последовательности Фибоначчи: {c}')
    with open('output.txt','w') as f:
        print('Записали в файл output.txt\n')
        f.write(f'{c}')

def start_task():
    print('\nЗадача 6: Числа Фибоначчи\n' +
          'Последовательностью Фибоначчи называется'+
          ' последовательность чисел a0, a1, ..., an, ..., где'+
          ' a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1).'+
          ' Требуется найти N-е число Фибоначчи. N (0 ≤ N ≤ 30).')
    find_Fibonachi()
