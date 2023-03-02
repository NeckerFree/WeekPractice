//using AlgorithmsApp;

//def binary_search(nums, key):
//    return binary_search_helper(nums, key, 0, len(nums))


//def binary_search_helper(nums, key, start_idx, end_idx):
//    middle_idx = (start_idx + end_idx) // 2
//    if start_idx == end_idx:
//        return None
//    if nums[middle_idx] > key:
//        return binary_search_helper(nums, key, start_idx, middle_idx)
//    elif nums[middle_idx] < key:
//        return binary_search_helper(nums, key, middle_idx + 1, end_idx)
//    else:
//        return middle_idx