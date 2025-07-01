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
    public void ReorderList(ListNode head)
    {
        if (head == null || head.next == null) return;
        // Use the fast and slow pointer technique to find the middle of the linked list
        ListNode fast = head;
        ListNode slow = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Reverse the second half of the linked list
        // slow is now at the middle of the list
        ListNode prev = null;
        ListNode current = slow;
        ListNode next = null;

        while (current != null)
        {

            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        // Now prev is the head of the reversed second half of the list
        // We will merge the two halves together
        ListNode first = head;
        ListNode second = prev;
        // We will use two pointers to merge the two halves
        while (second.next != null)
        {
            // We will take one node from the first half and one node from the second half
            ListNode t1 = first.next;
            ListNode t2 = second.next;
            // We will insert the second node after the first node
            first.next = second;
            // We will insert the first node after the second node
            second.next = t1;

            // Move the pointers forward
            // first will point to the next node in the first half
            first = t1;
            // second will point to the next node in the second half
            second = t2;
        }
    }
}
