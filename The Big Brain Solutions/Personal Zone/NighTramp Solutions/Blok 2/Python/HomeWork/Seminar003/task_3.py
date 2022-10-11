def sub_of_min_max_fract(tmp):
    min = max = int((tmp[0]-int(tmp[0]))*100)
    for i in range(0, len(tmp)):
        x = int((tmp[i]-int(tmp[i]))*100)
        if x < min: min = x
        elif x > max: max = x
    print(f'Ответ: {(max - min)/100}')

def start_task():
    print('\nЗадача 3: Разница дробных\n' +
          'Задайте список из вещественных чисел. '+
          'Напишите программу, которая найдёт '+
          'разницу между максимальным и минимальным '+
          'значением дробной части элементов.')
    tmp = [1.1, 1.2, 3.1, 5, 10.01]
    print(f'Входные данные: {tmp}\n')
    sub_of_min_max_fract(tmp)

start_task()
