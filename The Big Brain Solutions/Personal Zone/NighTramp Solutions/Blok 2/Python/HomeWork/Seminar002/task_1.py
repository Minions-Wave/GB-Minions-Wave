def find_min_times_to_turn(temp):
    min_0 = 0
    min_1 = 0
    for i in range(len(temp)):
        if temp[i] == 0: min_0 += 1
        else: min_1 += 1
    if min_0 < min_1: print(f'Ответ: {min_0}\n')
    else: print(f'Ответ: {min_1}\n')

def start_task():
    print('\nЗадача 1: Монетки\n' +
          'На столе лежат n монеток. Некоторые из них лежат '+
          'вверх решкой, а некоторые – гербом. Определите '+
          'минимальное число монеток, которые нужно '+
          'перевернуть, чтобы все монетки были повернуты '+
          'вверх одной и той же стороной.')
    print(f'Входной массив: [1,0,1,1,0]')
    find_min_times_to_turn([1,0,1,1,0])
    
# start_task()
