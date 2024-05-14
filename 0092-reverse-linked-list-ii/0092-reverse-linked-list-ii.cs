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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(head == null) return null;
        
        ListNode dummy = new ListNode(0, head);
        ListNode before = dummy;
        
        for(int i=1; i < left; i++)
        {
            before = before.next;
        }
        
        //Console.WriteLine(before.val);
        
        ListNode prev = before;
        ListNode curr = before.next;
        
        for(int i=left; i <= right; i++)
        {
            ListNode nextNode = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextNode;
        }
        
        
        before.next.next = curr;
        before.next = prev;
        
        return dummy.next;

    }
}