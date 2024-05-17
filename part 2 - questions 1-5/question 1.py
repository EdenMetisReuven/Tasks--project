import math
def num_len (number: int) -> int:
    number_lenght = int(math.log10(number)) +1
    return number_lenght

print(num_len(10000))