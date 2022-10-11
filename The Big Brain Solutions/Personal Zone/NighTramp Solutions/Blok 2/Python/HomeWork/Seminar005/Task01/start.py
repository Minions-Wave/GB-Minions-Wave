from main import *

def app():
    lib._gamemode = introduce()
    lib._players = introduce_player()
    winner = ''

    match lib._gamemode:
        case 1:
            winner = player_vs_ai()
        case 2:
            winner = player_vs_player()
    if not winner:
        print('У нас нет победителя.')
    else:
        print('Победил ', winner)

app()
