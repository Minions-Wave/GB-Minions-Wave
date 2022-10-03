def convert_to_binary(tmp):
    flag = False
    s = ''
    while not flag:
        if tmp < 2:
            s += str(tmp)
            flag = True
        else:
            s += str(tmp % 2)
            tmp = int(tmp / 2)
    print(f'Овтет: {s[::-1]}')

def start_task():
    print('\nЗадача 4: Перевод в двоичную\n' +
          'Напишите программу, которая будет '+
          'преобразовывать десятичное число в двоичное.')
    tmp = int(input('Введите число: '))
    convert_to_binary(tmp)

start_task()