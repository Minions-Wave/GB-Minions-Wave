import math

def n_list(num):
    res = []
    while num % 2 == 0:
        res.append(2)
        num = int(num/2)
    for i in range(3, int(math.sqrt(num)) + 1, 2):
        while num % i == 0:
            res.append(i)
            num = int(num/i)
    if num > 2:
        res.append(num)
    print(f'Список простых множителей: {res}\n')

def start_task():
    print('\nЗадача 2:\n' +
          'Задайте натуральное число N. Напишите программу, '+
          'которая составит список простых множителей числа N.')
    n_list(int(input('Задайте натуральное число: ')))
    
start_task()
