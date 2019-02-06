# Given an array of integers, return a new array such that each element at index i of the new array 
# is the product of all the numbers in the original array except the one at i.
# For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. 
# If our input was [3, 2, 1], the expected output would be [2, 3, 6].

def product_list(list_num):
    for i in range(len(list_num)):
        product = 1
        for j in range(len(list_num)):
            product *= list_num[j]
        product /= list_num[i]
        output_list.append(int(product))
    print(output_list)
    return output_list

input_list = [1, 2, 3, 4, 5]
output_list = []

if __name__ == "__main__":
    product_list(input_list)