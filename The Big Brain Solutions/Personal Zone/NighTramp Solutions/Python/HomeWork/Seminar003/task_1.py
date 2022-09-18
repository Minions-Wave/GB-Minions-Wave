def sum_of_not_even(tmp):
    sum = 0
    for i in range(1, len(tmp), 2):
        sum += tmp[i]
    return sum

def start_task():
    print('\nЗадача 1: Сумма нечетных\n' +
          'Задайте список из нескольких чисел. '+
          'Напишите программу, которая найдёт сумму '+
          'элементов списка, стоящих на нечётной позиции.')
    tmp = [2, 3, 5, 9, 3]
    print(f'Входные данные: {tmp}')
    print(f'Ответ {sum_of_not_even(tmp)}\n')

start_task()
