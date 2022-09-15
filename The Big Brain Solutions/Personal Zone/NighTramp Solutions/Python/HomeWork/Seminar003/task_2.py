def mult_of_num(tmp):
    mult = []
    _len = len(tmp)
    __len = int(_len/2)
    if len(tmp) % 2 > 0: __len+=1

    for i in range(0, __len):
        mult.append(f'{tmp[i] * tmp[_len-i-1]}')
        if i == _len-1-i:
            break
    print(f'Ответ: {mult}\n')

def start_task():
    print('\nЗадача 2: Произведение пар\n' +
          'Напишите программу, которая найдёт '+
          'произведение пар чисел списка. Парой '+
          'считаем первый и последний элемент, '+
          'второй и предпоследний и т.д.')
    tmp = [2, 3, 4, 5, 6]
    print(f'Входные данные: {tmp}')
    mult_of_num(tmp)
    tmp = [2, 3, 5, 6]
    print(f'Входные данные: {tmp}')
    mult_of_num(tmp)
start_task()
