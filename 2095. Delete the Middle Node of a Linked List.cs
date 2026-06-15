// Naive solution
public class Solution
{
    public ListNode DeleteMiddle(ListNode head)
    {
        var dict = new Dictionary<int, ListNode>();
        var length = 0;
        var dummy = head;
        while (dummy != null)
        {
            length++;
            dict[length - 1] = dummy;
            dummy = dummy.next;
        }
        if (length == 1) return null;
        var mid = length / 2;
        if (length == 2) head.next = null;
        else dict[mid - 1].next = dict[mid + 1];

        return head;
    }
}

// Optimal
public class Solution
{
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head.next == null) return null;
        ListNode fast = head, slow = head;

        while (fast.next != null && fast.next.next != null && fast.next.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        return head;
    }
}
