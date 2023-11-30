from math import gcd

a, b, c, d = int(input()), int(input()), int(input()), int(input())

def dr(m, n):
    return  m * n
def NOD(a, b):
    return gcd(a, b)
dr_1 = dr(a, c)
dr_2 = dr(b, d)
gcd_ = gcd(dr_1, dr_2)
res_1 = dr_1/gcd_
res_2 = dr_2/gcd_
print(f'{int(res_1)}/{int(res_2)}')
