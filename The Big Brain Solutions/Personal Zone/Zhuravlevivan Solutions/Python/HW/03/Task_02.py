# Напишите программу, которая найдёт произведение пар чисел списка.
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# Пример:

# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

from math import ceil


list_1 = []
list_2 = []

for i in range(int(input('Введите количество чисел: '))):
    list_1.append(int(input(f'Введите число № {i + 1}: ')))

for i in range(ceil(len(list_1) / 2)):
    list_2.append(list_1[i] * list_1[len(list_1) - i - 1])
    print(f'Пара № {i + 1}: {list_1[i]} и {list_1[len(list_1) - i - 1]}')
print(f'Произведение пар списка: {list_2}')

# x = 0
# for i in range(d):

#     print(i)

# x = s[i] *
# x = int(s[:-d-1:-1]) * int(s[:d+1])
# s2.append(x)
# for i in s[:-d-1:-1]:
#     for j in s[:d+1]:
#         x = ji * j
#         s2.append(x)

# x2 = s[1] * s[-2]
# x3 = s[2] * s[-3]

# print(s2)
