import lib

def find_min_div(n):
    for i in range(2, n+1):
        if (n % i == 0):
            return i

def start_task():
    print('\nЗадача 3: Минимальный делитель\n' +
          'Требуется найти наименьший натуральный делитель '+
          'целого числа N, отличный от 1.')
    x = find_min_div(lib.input_number('Введите число: ',True, 2,1000000))
    print(f'Ответ: {x}')

# start_task()