import math
def reverse_n_pi_digits(n: int) -> str:
    pi = str(math.pi)
    pi_num = pi[:n]
    return pi_num [::-1]

print (reverse_n_pi_digits(5))