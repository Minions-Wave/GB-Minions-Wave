# Сбор черники

kust = []

n = int(input('Введите количество кустов: '))
for i in range(1, n+1):
    kust.append(i)

kust.sort(reverse=True)
print(*kust)
print(sum(kust[:3]))
