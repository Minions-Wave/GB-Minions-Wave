import array

def find_position(path_input, path_output):
    with open(path_input, 'r') as file:
        n = int(file.readline())
        print(f'Человек в шеренге: {n}')
        height = array.array('i', (int(tmp) for tmp in file.readline().split()))
        print('Рост ребят: '+(str(height).split('[')[1]).rstrip('])'))
        height_petya = int(file.readline())
        print(f'Рост пети: {height_petya}')
        x = 1
        for i in range(n):
            if height_petya < height[i]: 
                x += 1
            else:
                break
        print(f'Петя будет стоять {x}й')
    with open(path_output, 'w') as file:
        print('Записали ответ в файл output.txt\n')
        file.write(f'{x}')

def start_task():
    print('\nЗадача 4: Щеренга\n' +
          'Петя впервые пришел на урок физкультуры в '+
          'новой школе. Перед началом урока ученики '+
          'выстраиваются по росту, в порядке невозрастания. '+
          'Напишите программу, которая определит на какое '+
          'место в шеренге Пете нужно встать, чтобы не '+
          'нарушить традицию, если заранее известен рост '+
          'каждого ученика и эти данные уже расположены по '+
          'невозрастанию (то есть каждое следующее число не '+
          'больше предыдущего). Если в классе есть несколько '+
          'учеников с таким же ростом, как у Пети, то '+
          'программа должна расположить его после них.')
    find_position('input.txt', 'output.txt')

start_task()
