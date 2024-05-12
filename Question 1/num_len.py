import math
def num_len (number: int) -> int:
    number_lenght = int(math.log(number))
    return number_lenght

num = int(input())
print(num_len(num))