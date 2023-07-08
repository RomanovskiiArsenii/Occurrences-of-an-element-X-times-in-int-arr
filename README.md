# Occurrences of an element X times in int arr

Given an array and a number, vethod creates a new array that contains each number 
of list at most N times, without reordering.
For example if the input number is 2, and the input list is [1,2,3,1,2,1,2,3], 
you take [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being 
in the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
