characteristic = lambda x: x
def same_by(characteristic, objects):    
    if len(set(characteristic(i) for i in objects)) == 1 or not objects:
        return True
    else:
        return False

values = [0, 2, 4, 6, 8, 10]

if same_by(lambda x: x % 2, values):
    print("same")
else:
    print("different")

values = ["asd", "dsf", "qwe"]

if same_by(lambda x: len(x), values):
    print("same")
else:
    print("different")