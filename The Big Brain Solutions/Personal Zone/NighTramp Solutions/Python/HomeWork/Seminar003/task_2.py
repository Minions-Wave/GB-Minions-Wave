def mult_of_num(tmp):
    mult = []
    _len = len(tmp)
    for i in range(0, int(_len/2)+1):
        mult.append(f'{tmp[i] * tmp[_len-i-1]}')
        if i == _len-1-i:
            break
    print(mult)

def start_task():
    print('\nЗадача 2: Произведение пар\n' +
          'Напишите программу, которая найдёт '+
          'произведение пар чисел списка. Парой '+
          'считаем первый и последний элемент, '+
          'второй и предпоследний и т.д.')
tmp = [1, 2, 3, 4, 5, 6, 7, 8, 9]
mult_of_num(tmp)
