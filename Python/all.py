def gcd(a, b):
    while (b != 0):
        r = a % b
        a = b
        b = r
    return a
def lcm(a, b):
    return (a / gcd(a, b) * b)