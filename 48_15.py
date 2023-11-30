from math import gcd

a, b, c, d = int(input()), int(input()), int(input()), int(input())

def dr(m, n):
    return  m + n
def NOD(a, b):
    return gcd(a, b)
znam = NOD(b, d)
a *= znam
b *= znam
c *= znam
d *= znam
dr_1 = dr(a, c)
gcd_ = gcd(dr_1, b)
res_1 = dr_1/gcd_
res_2 = b/gcd_
print(f'{int(res_1)}/{int(res_2)}')
