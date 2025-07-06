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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode fast = head;
        ListNode slow = head;
        int counter = 0;
        while (counter < n)
        {
            if (fast == null)
            {
                return head; // If n is greater than the length of the list
            }
            // Move the fast pointer n steps ahead
            fast = fast.next;
            counter++;
        }

        // If fast is null, it means we need to remove the head
        if (fast == null)
        {
            return head.next;
        }
        // Move both pointers until fast reaches the end of the list
        // slow will be at the (n+1)th node from the end
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        // Remove the nth node from the end
        slow.next = slow.next.next;
        return head;
    }
}
