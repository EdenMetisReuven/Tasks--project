def pythagorean_triplet_by_sum(sum: int)->str:

    a = int(sum**0.5)
        # a + b + c = a*(a + 1) = sum
    sum_perimeter = a * (a + 1)
    if a%2 != 0:
        if sum_perimeter == sum:
            b = (a**2 - 1)/2
            c= (a**2 + 1)/2
        if (b%1 == 0 and c%1 == 0):
            return (f"{a}<{b}<{c}")
    else:
        a=0
        for a in range(1, sum):
            for b in range(a, sum):
                c= sum -a -b
                if (a**2 + b**2 == c**2):
                    return (f"{a}<{b}<{c}")
    return ("The number does not have a trigonometric triple")
print (pythagorean_triplet_by_sum(20))