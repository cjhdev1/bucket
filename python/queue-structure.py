# Queue is First in first out (FIFO). Unlock stack which is first in last out (FILO)

from collections import deque
import queue

# A way to do queues with collections
q = deque()

q.appendleft(5)
q.appendleft(15)
q.appendleft(25)
q.appendleft(35)
q.appendleft(45)
q.appendleft(55)

print(q.pop()) # 5 because it was first in
print(q.pop()) # so on and so on...
print(q.pop())
print(q.pop())
print(q.pop())
print(q.pop())

# Do another way with queue import
qq = queue.Queue()
print(qq.empty()) # True
qq.put(1)
print(qq.empty()) # Now False

class QueueCustomClass:
    def __init__(self):
        self.buffer = deque()
    
    def enqueue(self, val):
        self.buffer.appendleft(val)

    def dequeue(self):
        return self.buffer.pop()

    def is_empty(self):
        return len(self.buffer) == 0

    def size(self):
        return len(self.buffer)

qqq = QueueCustomClass()

# A good real world example in this might be NYSE sending data to a queue for other finance websites to consume the data
qqq.enqueue({
    'company': 'Salesforce',
    'timestamp': '3 jul, 9:13 PM',
    'price': 300.00
})

qqq.enqueue({
    'company': 'Salesforce',
    'timestamp': '3 jul, 9:14 PM',
    'price': 400.00
})

qqq.enqueue({
    'company': 'Salesforce',
    'timestamp': '3 jul, 9:15 PM',
    'price': 500.00
})

print(qqq.buffer) # Show it all
print(qqq.size()) # Should be 3

qqq.dequeue() # You would assign this to a variable and then parse the JSON
print(qqq.size()) # Should be 2

qqq.dequeue() # You would assign this to a variable and then parse the JSON
print(qqq.size()) # Should be 1

qqq.dequeue() # You would assign this to a variable and then parse the JSON
print(qqq.size()) # Should be 0

# Keep checking for is_empty or 0 on size to determine if you finished the queue
print(qqq.is_empty())

'''
Output:
    5
    15
    25
    35
    45
    55
    True
    False
    deque([{'company': 'Salesforce', 'timestamp': '3 jul, 9:15 PM', 'price': 500.0}, {'company': 'Salesforce', 'timestamp': '3 jul, 9:14 PM', 'price': 400.0}, {'company': 'Salesforce', 'timestamp': '3 jul, 9:13 PM', 'price': 300.0}])
    3
    2
    1
    0
    True
'''