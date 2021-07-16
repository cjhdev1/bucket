# https://en.wikipedia.org/wiki/Heap_(data_structure)
# 
# Disadvantages
# 
# Relatively slow as compared to Quicksort
# Cache inefficient
# Not stable
# Not really adaptive (Doesn't get faster if given somewhat sorted array)

'''
Example
     1
    / \
   /   \
  2     \
 / \     3
4   5   / \
       9   \
            8
           / \
          6   7
'''
import heapq

li = [5, 7, 9, 1, 3]
'''
     5
    / \
   /   \
  7     9
 / \ 
1   2
'''
print(li)

heapq.heapify(li)
'''
     1
    / \
   /   \
  3     9
 / \ 
7   5
'''
print(li)

heapq.heappush(li, 4)
'''
     1
    / \
   /   \
  3     4
 / \   / 
7   5 9   
'''
print(li)

heapq.heappop(li) # Pops the first element of the arrary/heap which is 1
'''
     3
    / \
   /   \
  5     4
 /     / 
7     9   
'''
print(li)

heapq.heappush(li, 10)
'''
     3
    / \
   /   \
  5     4
 / \   / 
7   9 10 
'''
print(li)

heapq.heappushpop(li, 3) # Same as above but will pop the 3 then push it back in the heap
'''
     3
    / \
   /   \
  5     4
 / \   / 
7   9 10 
'''
print(li)