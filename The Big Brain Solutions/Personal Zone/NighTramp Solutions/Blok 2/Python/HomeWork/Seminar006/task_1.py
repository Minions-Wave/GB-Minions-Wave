transfomation = lambda x: x

values = [1, 2, 3, 5, "abc"]
transformed_values = list(map(transfomation, values))

if values == transformed_values:
    print("ok")
else:
    print("fail")