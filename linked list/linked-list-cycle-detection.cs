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
    public bool HasCycle(ListNode head)
    {
        // Using Floyd's Cycle Detection Algorithm (Tortoise and Hare)
        // This algorithm uses two pointers, one moving at twice the speed of the other.
        ListNode slow = head;
        ListNode fast = head;
        // Move slow pointer by 1 step and fast pointer by 2 steps
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            // If the two pointers meet, there is a cycle in the linked list
            if (slow == fast)
            {
                return true;
            }
        }
        return false;
    }
}
