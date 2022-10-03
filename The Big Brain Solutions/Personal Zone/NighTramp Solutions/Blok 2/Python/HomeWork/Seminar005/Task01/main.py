import lib
from lib import *
from random import randint, choice

def player_vs_player():
    count = rand_choice_first_player()
    total = lib._total_sweets
    while total > lib._max_number_move:
        print(count)
        move = int(input_number(f'{lib._players[count % 2]}, {choice(lib._moves)}',False,1,lib._max_number_move))
        if move > total or move > lib._max_number_move:
            print(f'Можно взять не более {lib._max_number_move} конфет, у нас всего {total} конфет')
            chance = 2
            while chance > 0:
                if total >= move <= lib._max_number_move:
                    break
                print(f'Попробуйте ещё раз, у Вас {chance} попытки')
                move = int(input())
                chance -= 1
            else:
                return print(f'Попыток не осталось. Game over!')
        total = total - move
        print(f'Осталось {total} конфет')
        count += 1
    count += 1
    return lib._players[not count % 2]

def player_vs_ai():
    count = rand_choice_first_player()
    total = lib._total_sweets
    while total > lib._max_number_move:
        if total == (lib._max_number_move and total < lib._max_number_move and total > 1):
            move = total -1
            print(f'Я забираю {move}')
        elif not count % 2:
            move = randint(1, lib._max_number_move)
            print(f'Я забираю {move}')
        else:
            move = int(input_number(f'{lib._players[0]}, {choice(lib._moves)}',False,1,lib._max_number_move))
            if move > total or move > lib._max_number_move:
                print(f'Можно взять не более {lib._max_number_move} конфет, у нас всего {total} конфет')
                chance = 2
                while chance > 0:
                    if total >= move <= lib._max_number_move:
                        break
                    print(f'Попробуйте ещё раз, у Вас {chance} попытки')
                    move = int(input())
                    chance -= 1
                else:
                    return print(f'Попыток не осталось. Game over!')
        total = total - move
        print(f'Осталось {total} конфет')
        count += 1
    return lib._players[not count % 2]
