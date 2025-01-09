//Recursive solution:
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {   
        //If we're at the end of the list, return null
        if (head == null) return null;
        //Keep track of the last listnode we ever see which will be the new head of the list after reversal
        ListNode newHead = head;
        //If theres anything to reverse
        if (head.next != null)
        {
            //Update newHead
            newHead = ReverseList(head.next);
            //Set the next.next value to the current value to complete the reversal
            head.next.next = head;
        }
        head.next = null;
        return newHead;
    }
}

//Iterative solution
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null)
        {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;           
        }
        return prev;
    }
}
