/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummy = new();
        ListNode current = dummy;
        int carry = 0;

        while (l1 != null || l2 != null || carry > 0)
        {
            int v1 = 0;
            int v2 = 0;

            if (l1 != null)
            {
                v1 = l1.val;
            }
            if (l2 != null)
            {
                v2 = l2.val;
            }

            int val = v1 + v2 + carry;

            carry = val / 10;
            val = val % 10;
            ListNode node = new ListNode();
            node.val = val;
            current.next = node;

            current = current.next;

            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }
        }

        return dummy.next;

    }
}
