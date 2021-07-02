# This is a reference for linked lists in python
##########

'''
Root
[data][next]    [data][next]    [data][next]
  5     >>>>>>>   17    >>>>>>>   8     End (null or none)

get_size()
find(data)
add(data)
remove(data)
'''

class Node(object):
    def __init__(self, d, n = None):
        self.data = d
        self.next_node = n
    
    def get_next(self):
        return self.next_node

    def set_next(self, n):
        self.next_node = n
    
    def get_data(self):
        return self.data

    def set_data(self, d):
        self.data = d


class LinkedList (object):
    def __init__(self, r = None):
        self.root = r
        self.size = 0

    def get_size(self):
        return self.size

    def add(self, d):
        new_node = Node (d, self.root)
        self.root = new_node
        self.size += 1

    def remove (self, d):
        this_node = self.root
        prev_node = None
        while this_node:
            if this_node.get_data() == d:
                if prev_node:
                    prev_node.set_next(this_node.get_next())
                else:
                    # Have to change the current node and then reassign the next node for deleting the last node bug. 
                    self.root = this_node.next_node
                self.size -= 1
                return True
            else:
                prev_node = this_node
                this_node = this_node.get_next()
        return False

    def find(self, d):
        this_node = self.root
        while this_node:
            if this_node.get_data() == d:
                return d
            else:
                this_node = this_node.get_next()
        return None

myList = LinkedList()
myList.add(5)
myList.add(10)
myList.add(500)
myList.add(1500)
print(myList.remove(500))
print(myList.find(10))

myList2 = LinkedList()
myList2.add(5)
myList2.add(10)
myList2.add(500)
myList2.add(1500)
print(myList2.remove(1500))
print(myList2.find(1500))

myList3 = LinkedList()
myList3.add(5)
myList3.add(10)
myList3.add(500)
myList3.add(1500)
print(myList3.remove(999))
print(myList3.find(999))


# Output
# --------
# True
# 10
# True
# None
# False
# None