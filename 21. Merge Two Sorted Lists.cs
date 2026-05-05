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
 
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null) return null;
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        var head = new ListNode();

        if (list1.val < list2.val)
        {
            head.val = list1.val;
            list1 = list1.next;
        }
        else
        {
            head.val = list2.val;
            list2 = list2.next;
        }
        var dummy = head;

        while(list1 != null || list2 != null)
        {
            dummy.next = new ListNode();
            dummy = dummy.next;

            if (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    dummy.val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    dummy.val = list2.val;
                    list2 = list2.next;
                }
            }
            else if (list1 != null)
            {
                dummy.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                dummy.val = list2.val;
                list2 = list2.next;
            }
        }

        return head;
    }
}
