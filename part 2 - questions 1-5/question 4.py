import matplotlib.pyplot as plt
import numpy as np
from scipy.stats import pearsonr
def number_series():
    print ("Enter num: ")
    received_number = float(input())
    number_list = []
    graph_list = []
    number_list.append(received_number)
    graph_list.append(received_number)
    while received_number != -1:
        received_number = float(input())
        number_list.append(received_number)
        graph_list.append(received_number)
    print (f"positiv numbers: {positiv_numbers(number_list)}")
    print (f"average numbers: {numbers_average(number_list)}")
    print (sort_list(number_list))
    print (pearsonr_(graph_list))
    matplot_(graph_list)

def pearsonr_(recived_number: list):
    index = []
    for i in range(1, len(recived_number) +1):
        index.append(i)
    pearsonr_correlation, _ = pearsonr(index, recived_number)
    return pearsonr_correlation
def matplot_(recived_number: list):
    arrival_order =[]
    for i in range (len(recived_number)):
        arrival_order.append(i+1)
    plt.scatter(arrival_order, recived_number)
    plt.show()

def positiv_numbers(all_numbers: list) -> int:
    count_numbers = 0
    for i in range(len(all_numbers)):
        if all_numbers[i] > 0:
            count_numbers += 1
    return count_numbers

def numbers_average(number_list: list) -> int:
    sum_numbers = 0
    for i in range (len(number_list)):
        sum_numbers += number_list[i]
    return (sum_numbers//len(number_list))

def sort_list (number_list: list) -> list:
     number_sort = number_list
     number_sort.sort()
     return number_sort



print (number_series())