
from random import randint


_messages = ['Выберите игровой режим: ',
             'Введите имя Первого игрока: ',
             'Введите имя Второго игрока: ']

_moves = ['Ваш ход брать конфеты\n',
          'Возьмите конфеты\n',
          'сколько конфет берем?\n',
          'берите еще\n', 
          'Ваш ход\n']

_errors = ['Вы ввели не число!', 
          'Значение вне диапазона.', 
          'Не может быть равно 0!']

_gamemode = None
_players = []
_max_number_move = 28
_total_sweets = 2021

def input_number(str, not_null = False, a = None, b = None):
    flag = False
    tmp = None
    while(not flag):
        try:
            tmp = int(input(str))
            if a != None and b != None:
                if a <= tmp <= b:
                    flag = True
                else:
                    print(_errors[1])
            else:
                flag = True
            if not_null and tmp == 0:
                flag = False
                print(_errors[0])
        except:
            print(_errors[0])
    return tmp

def introduce():
    print('"Игра: Конфеты"\n'+
          'В игре участвуют два игрока.\n'+
          'В зависимости от режима можно играть вдвоем либо против ИИ.\n'+
          'Кто ходит первым, определяется случайно.\n'+
          'Режимы игры:\n'+
          '1 - Против ИИ\n'+
          '2 - Против Игрока\n', end='')
    return input_number(_messages[0],True,1,2)

def introduce_player():
    players = ['','Bot']
    players[0] = input(_messages[1])
    if _gamemode == 2: 
        players[1] = input(_messages[2])
    return players
    
def rand_choice_first_player():
    first = randint(0,1)
    return first

