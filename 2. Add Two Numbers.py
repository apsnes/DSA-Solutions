# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        l1string = str(l1.val)
        l2string = str(l2.val)
        while(l1.next):
            l1 = l1.next
            l1string += str(l1.val)
        while(l2.next):
            l2 = l2.next
            l2string += str(l2.val)
        l3 = int(l1string[::-1]) + int(l2string[::-1])
        l3string = str(l3)
        l3string = l3string[::-1]
        head = dummy = ListNode(int(l3string[0]))
        n = len(l3string)
        for i in range(1, n):
            dummy.next = ListNode(int(l3string[i]))
            dummy = dummy.next
        return head
