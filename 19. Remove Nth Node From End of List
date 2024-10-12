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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null)
        {
            if (fast == slow)
            {
                return true;
            }
            slow = slow.next;
            fast = fast.next.next;
        }

        return false;
    }
}
