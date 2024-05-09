
# def pythagorean_triplet_by_sum(sum: int):
#     a = 1
#     while a != sum:
#         # a + b + c = a*(a + 1) = sum
#         sum_perimeter = a * (a + 1)
#         if sum_perimeter == sum:
#             b = (a**2 - 1)/2
#             c= (a**2 + 1)/2
#             return (f"{a}<{b}<{c}")
#
#         a +=1
#     return ("The number does not have a trigonometric triple")

def pythagorean_triplet_by_sum(sum: int):

    a = int(sum**0.5)
        # a + b + c = a*(a + 1) = sum
    sum_perimeter = a * (a + 1)
    if sum_perimeter == sum:
        b = (a**2 - 1)/2
        c= (a**2 + 1)/2
        return (f"{a}<{b}<{c}")
    return ("The number does not have a trigonometric triple")
print (pythagorean_triplet_by_sum(15))