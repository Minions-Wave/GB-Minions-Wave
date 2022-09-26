import random

def u_list(num):
    res = []
    for i in range(0,len(num)):
        flag = True
        for j in range(0,len(num)):
            if num[i] == num[j] and i!=j:
                flag = False
                break
        if flag:
            res.append(num[i])
    return res

def start_task():
    print('\nЗадача 3:\n' +
          'Задайте последовательность чисел. Напишите '+
          'программу, которая выведет список неповторяющихся '+
          'элементов исходной последовательности.')
    num = [random.randint(0, 10) for _ in range(0, 10)]
    print('Исходный набор чисел: ', end='')
    print(*num, sep=', ', end='.\n')
    res = u_list(num)
    print('Овтвет: ', end='')
    print(*res, sep=', ', end='.\n')

start_task()
