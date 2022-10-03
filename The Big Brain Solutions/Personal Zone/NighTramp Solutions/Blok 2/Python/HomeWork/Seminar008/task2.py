inputs = [1, 2, 3, 4, 5, 12]


def reverses(inp, i):
    if i >= 0: 
        print(inp[i], end=' ')      
        i -= 1
        reverses(inp, i)
       
reverses(inputs, len(inputs)-1)