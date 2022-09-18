# Задайте натуральное число N.
# Напишите программу, которая составит список простых множителей числа N.

from multiprocessing.forkserver import main


n = int(input('Введите число: '))
delit = 2
sdel = []
while delit ** 2 <= n:
    if n % delit == 0:
        n //= delit
        sdel.append(delit)
    else:
        delit += 1
if n != 1:
    sdel.append(delit)

print(f'Список простых множителей числа: {sdel}')
