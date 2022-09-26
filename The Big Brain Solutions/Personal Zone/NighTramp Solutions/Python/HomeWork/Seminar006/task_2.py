def find_farthest_orbit(orbits):
    return  max(orbits, key=lambda x: 3.14159 * x[0] * x[1] if (x[0] != x[1]) else False)

orbits = [(1, 3), (2.5, 10), (7, 2), (6, 6), (4, 3)]
print(*find_farthest_orbit(orbits))