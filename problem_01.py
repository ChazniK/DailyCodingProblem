# Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
# For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

# think about divide and conquer approach...
def sum_of_k(num_list, k_val):
    print(num_list)
    sorted_list = sorted(num_list)
    print(sorted_list)
    length = len(sorted_list)
    if length < 2:
        return False
    else:
        for i in range(length - 1):
            for j in range(1, length):
                if (i + j) < length:
                    first_num = sorted_list[i]
                    second_num = sorted_list[i + j]
                    if first_num + second_num > k_val:
                        break
                    elif (first_num + second_num) == k_val:
                        print(str(first_num) + " " + str(second_num))
                        return True
        return False

number_list = [1, 2, 5, 6, 17, 30, 24, 19, 10, 11, 6, 7, 11, 15]
k = 17

if __name__ == "__main__":
    print(sum_of_k(number_list, k))