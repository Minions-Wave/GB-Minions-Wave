# Напишите программу для. проверки истинности утверждения
#  ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

import lib

def predicat():
    print('+---+---+---+--------------+--------------+---+')
    print('| X | Y | Z | ¬(X + Y + Z) | ¬X & ¬Y & ¬Z | F |')
    print('+---+---+---+--------------+--------------+---+')
    for x in range(2):
        for y in range(2):
            for z in range(2):
                tmp = int(not(x or y or z) == (not x and not y and not z))
                print(f'| {x} | {y} | {z} |'+
                      f'            {int(not(x or y or z))} |'+
                      f'            {int(not x and not y and not z)} |'+
                      f' {tmp} |')
    print('+---+---+---+--------------+--------------+---+\n')

def start_task():
    print('\nЗадача 2: Проверка истинности предикат\n' +
          'Напишите программу для. проверки истинности '+
          'утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для'+
          ' всех значений предикат.')
    predicat()
