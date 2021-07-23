class node:
    def __init__(self, value=None):
        self.value = value
        self.left_child = None
        self.right_child = None

class binary_search_tree:
    def __init__(self):
        self.root = None

    def insert(self, value):
        if self.root == None:
            self.root = node(value)
        else:
            self._insert(value, self.root)

    def _insert(self, value, cur_node):
        if value < cur_node.value:
            if cur_node.left_child == None:
                cur_node.left_child = node(value)
            else:
                self._insert(value, cur_node.left_child)
        elif value > cur_node.value:
            if cur_node.right_child == None:
                cur_node.right_child = node(value)
            else:
                self._insert(value, cur_node.right_child)
        else:
            print("Value already in tree")

    def print_tree(self):
        if self.root != None:
            self._print_tree(self.root)

    def _print_tree(self, cur_node):
        if cur_node != None:
            self._print_tree(cur_node.left_child)
            print (cur_node.value)
            self._print_tree(cur_node.right_child)

    def height(self):
        if self.root != None:
            return self._height(self.root, 0)
        else:
            return 0

    def _height(self, cur_node, cur_height):
        if cur_node == None:
            return cur_height
        left_height = self._height(cur_node.left_child, cur_height + 1)
        right_height = self._height(cur_node.right_child, cur_height + 1)
        return max(left_height, right_height)

    def search(self, value):
        if self.root != None:
            return self._search(value, self.root)
        else:
            return False

    def _search(self, value, cur_node):
        if value == cur_node.value:
            return True
        elif value < cur_node.value and cur_node.left_child != None:
            return self._search(value, cur_node.left_child)
        elif value > cur_node.value and cur_node.right_child != None:
            return self._search(value, cur_node.right_child)
        return False

def fill_tree(tree, num_elems = 100, max_int = 1000):
    from random import randint
    for _ in range(num_elems):
        cur_elem = randint(0, max_int)
        tree.insert(cur_elem)
    return tree

'''
Output

Value already in tree
Value already in tree
Value already in tree
Value already in tree
Value already in tree
Value already in tree
6
9
31
60
70
74
78
81
84
90
95
119
123
124
137
148
155
157
165
180
192
205
215
223
226
247
273
283
316
327
328
335
343
347
368
408
409
426
443
450
472
479
482
530
539
552
554
560
582
584
618
619
636
640
641
646
649
650
651
656
665
675
676
680
706
737
750
755
773
776
805
806
812
847
853
860
865
867
880
882
883
884
909
921
924
935
941
945
948
956
967
970
987
1000
Tree height: 14
True
True
False
'''
tree = binary_search_tree()
tree = fill_tree(tree)
tree.print_tree()

print("Tree height: " + str(tree.height()))


tree.insert(5)
tree.insert(100)

print(tree.search(5))
print(tree.search(100))
print(tree.search(5000))