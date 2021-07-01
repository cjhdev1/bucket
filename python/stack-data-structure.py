# This is a reference for stack data strucutures in python
##########

"""
A B C D

to 

D
C
B
A

and vice versa

Push and popping is how you get the data
"""

class Stack():
    def __init__(self):
        self.items = [] # Just creating an empty list

    def push(self, item):
        self.items.append(item)

    def pop(self):
        return self.items.pop()

    def is_empty(self):
        return self.items == []

    def peek(self):
        if not self.is_empty():
            return self.items[-1]

    def get_stack(self):
        return self.items


"""
Output below is
['A', 'B']
['A', 'B', 'C']
['A', 'B']
False
True
Peek: D
"""
s = Stack()
s.push("A") # Pushing A to the stack
s.push("B") # Pushing B to the stack
print (s.get_stack())
s.push("C") # Pushing C to the stack
print (s.get_stack())
s.pop() # Popping C off the stack
print (s.get_stack())

ss = Stack()
print(s.is_empty()) # Checking to see if the stack is empty, s is False
print(ss.is_empty()) # Checking to see if the stack is empty, ss is True

sss = Stack()
sss.push("A") # Pushing A to the stack
sss.push("B") # Pushing B to the stack
sss.push("C") # Pushing C to the stack
sss.push("D") # Pushing D to the stack
print("Peek: " + sss.peek()) # Peeking at the stack to see the next value to pop off