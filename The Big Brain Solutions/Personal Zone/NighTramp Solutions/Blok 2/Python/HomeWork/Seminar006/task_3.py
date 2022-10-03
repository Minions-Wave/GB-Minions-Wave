_str = "пара-ра-рам рам-пам-папам па-ра-па-дам".split()

rez = [sum(x in 'аеёиоуыэюя' for x in i) for i in _str]

if len(set(rez)) == 1: # именно == 1
    print("Парам пам-пам") 
else: 
    print("Пам парам")