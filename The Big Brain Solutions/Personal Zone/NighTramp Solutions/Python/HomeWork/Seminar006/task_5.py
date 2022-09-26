def print_operation_table(operation, rows = 9, cols = 9):
    for i in range(1, rows + 1):
        for j in range(1, cols + 1):
            print(operation(i, j), end='\t')
        print()            

print_operation_table(lambda x, y: x * y, 5, 3)