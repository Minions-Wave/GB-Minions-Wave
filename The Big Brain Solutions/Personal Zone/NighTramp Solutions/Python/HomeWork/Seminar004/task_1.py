from decimal import Decimal


def pi(tmp):
    p = 3
    # i = 2
    # n = 0
    # b = 1
    # while n < tmp:
    #     p += 4/(i * (i+1) * (i+2))*b
    #     n += 1
    #     i += 2
    #     b *= -1
    # print(i * (i+1) * (i+2))
    # return p
    result = Decimal(3.0)
    op = 1
    n = 2
    for n in range(2 ,2*tmp+1 ,2):
            result += 4/Decimal(n*(n+1)*(n+2)*op)
            op *= -1
    return result

def my_round(tmp):
    n = 1

def start_task():
    print('\nЗадача 1:\n' +
          'Пользователь вводит число, Вам необходимо '+
          'вывести число Пи с той точностью знаков '+
          'после запятой, сколько указал пользователь'+
          '(БЕЗ ИСПОЛЬЗОВАНИЯ МОДУЛЕЙ/БИБЛИОТЕК)')
    p = pi(int(input('Введите число: ')))
    print(f'Pi = {p:.30f}')

start_task()
