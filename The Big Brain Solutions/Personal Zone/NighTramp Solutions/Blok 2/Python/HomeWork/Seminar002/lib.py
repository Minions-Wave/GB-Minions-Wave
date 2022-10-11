import math

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
                    print('Значение вне диапазона.')
            else:
                flag = True
            if not_null and tmp == 0:
                flag = False
                print('Не может быть равно 0!')
        except:
            print('Вы ввели не число!')
    return tmp

class Dot:
    x = None
    y = None
    def __init__(self):
        self.x = input_number('Введите x: ',True)
        self.y = input_number('Введите y: ',True)

class Line:
    A = None
    B = None
    lingth = None
    def __init__(self):
        self.A = Dot()
        self.B = Dot()
        self.lingth = round(float(math.sqrt((self.B.x - self.A.x) ** 2 + (self.B.y - self.A.y) ** 2)),2)
    def print_info(self):
        print(f'Расстояние между A({self.A.x},{self.A.y}) и B({self.B.x},{self.B.y}) равно: {self.lingth}\n')
