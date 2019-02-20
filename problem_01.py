#####################################################################################################
# Google.                                                                                           #
# Given a list of numbers and a number k, return whether any two numbers from the list add up to k. #
# For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17                     #
#####################################################################################################

list_of_numbers = [23, -6, 10, 6, 15, 3, 7, 10, 10, 4, 5, 8, 3]
# list_of_numbers = []
# list_of_numbers = [-12, -5]
# list_of_numbers = [12, 5]
# list_of_numbers = [23, -6]
# list_of_numbers = [17]
# list_of_numbers = [17, 0, 5]
k = 17

def adds_up_to_k(lst, num):
    list_count = len(lst)
    dict_of_numbers = {}
    # creates dictionary from the list using the numbers as keys sets values to 1, skips duplicates
    if list_count > 1:
        for i in range(list_count):
            current_number = lst[i]
            if current_number in dict_of_numbers:
                continue
            else:
                dict_of_numbers[current_number] = 1
        for number in dict_of_numbers:
            if (k - number) in dict_of_numbers:
                return True
    return False    

if __name__ == "__main__":
    print(str(adds_up_to_k(list_of_numbers, k)))