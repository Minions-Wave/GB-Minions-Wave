def check(n):
    if type(n) == int:
        return n

    if 'в' in n.lower():
        return 2
    if 'д' in n.lower():
        return 3
    if 'к' in n.lower():
        return 4
    return 11