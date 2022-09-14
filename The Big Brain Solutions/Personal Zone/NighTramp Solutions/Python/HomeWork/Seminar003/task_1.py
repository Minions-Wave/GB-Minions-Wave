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
    print('Входные данные: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]')
    tmp = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
    print(f'Ответ {sum_of_not_even(tmp)}')

start_task()
