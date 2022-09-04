# Напишите программу, которая принимает на вход
# координаты двух точек и находит расстояние
# между ними в 2D пространстве.

# Пример:

# - A (3,6); B (2,1) -> 5,09
# - A (7,-5); B (1,-1) -> 7,21

from math import sqrt as sqroot

ax = int(input('Input x dot a: '))
ay = int(input('Input y dot a: '))
bx = int(input('Input x dot b: '))
by = int(input('Input y dot b: '))

ab = sqroot(((bx - ax) ** 2) + ((by - ay) ** 2))

print(round(ab, 2))
