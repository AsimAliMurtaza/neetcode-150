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
    public ListNode ReverseList(ListNode head)
    {

        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;
        while (current != null)
        {
            // Store the next node
            next = current.next;
            // Reverse the current node's pointer
            current.next = prev;
            // Move the pointers one position ahead
            prev = current;
            // Move to the next node
            current = next;

        }
        // At the end of the loop, prev will be the new head of the reversed linked list
        return prev;
    }
}
