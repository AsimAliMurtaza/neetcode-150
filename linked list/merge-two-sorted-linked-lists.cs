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
        //make a dummy node to keep track of head of merged list
        ListNode dummyNode = new ListNode();
        //a tailnode to keep track of the last node in the merged list
        ListNode tailNode = dummyNode;

        while (list1 != null && list2 != null)
        {
            //compare the values of the two lists and append the smaller one to the merged list
            if (list1.val <= list2.val)
            {
                //append the node from list1 to the merged list
                tailNode.next = list1;
                //move the pointer of list1 to the next node
                list1 = list1.next;
                //move the tailNode pointer to the next node
                tailNode = tailNode.next;
            }
            else
            {
                tailNode.next = list2;
                list2 = list2.next;
                tailNode = tailNode.next;
            }
        }
        //if one of the lists is not null, append the remaining nodes to the merged list
        tailNode.next = list1 ?? list2;
        //return the merged list starting from the next of dummyNode
        return dummyNode.next;
    }
}