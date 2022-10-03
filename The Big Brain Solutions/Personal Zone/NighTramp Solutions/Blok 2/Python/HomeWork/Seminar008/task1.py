inputs = [1, 3, 3, 3, 4]

min = min(inputs)
max = max(inputs)

ouptuts = lambda x: [(min if i == max else i) for i in x]

print(inputs)
print(ouptuts(inputs))