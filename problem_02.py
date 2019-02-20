#####################################################################################################
# Uber.                                                                                             #
# Given an array of integers, return a new array such that each element at index i of the new array #
# is the product of all the numbers in the original array except the one at i.                      #
# For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24].# 
# If our input was [3, 2, 1], the expected output would be [2, 3, 6].                               #
# Follow-up: what if you can't use division?                                                        #
#####################################################################################################

#Test Cases
# array_of_integers = [1, 2, 3, 4, 5]
# array_of_integers = [3, 2, 1]
# array_of_integers = [1]
array_of_integers = [2, 3, 1, 0]

def create_product_arr(array_of_ints):
    product_arr = []
    list_count = len(array_of_ints)
    for i in range(list_count):
        result = 1
        for j in range(list_count):
            if (i < j) or (i > j):
                result *= array_of_ints[j]
            else:
                continue
        product_arr.append(int(result))
    return product_arr

if __name__ == "__main__":
    print(create_product_arr(array_of_integers))


