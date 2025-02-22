# import os


# print(".")
# os.system("cls")

# def custom_sort(unsorted_list):
#     length = len(unsorted_list)
#     for i in range(length):
#         # Iterate through the unsorted part of the list
#         for j in range(i + 1, length):
#             # Compare and swap if necessary
#             if unsorted_list[i] > unsorted_list[j]:
#                 unsorted_list[i], unsorted_list[j] = unsorted_list[j], unsorted_list[i]
#     return unsorted_list

# # Example usage
# unsorted_list = [3, 1, 4, 2]
# sorted_list = custom_sort(unsorted_list)
# print("Sorted list:", sorted_list)

def reverse_selection_sort_ascending(unsorted_list):
    length = len(unsorted_list)
    for i in range(length - 1, -1, -1):
        # Find the maximum element in the unsorted part
        max_index = i
        for j in range(i - 1, -1, -1):
            if unsorted_list[j] > unsorted_list[max_index]:
                max_index = j
        # Swap the maximum element with the element at the current index
        unsorted_list[i], unsorted_list[max_index] = unsorted_list[max_index], unsorted_list[i]
    return unsorted_list

# Example usage
unsorted_list = [3, 1, 4, 2]
sorted_list = reverse_selection_sort_ascending(unsorted_list)
print("Sorted list:", sorted_list)