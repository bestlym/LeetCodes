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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode left = head, right = head;
        
        while(right != null){
            right = right.next;
            
            if(n < 0) left = left.next;
            n--;  //  1 0
        }
        
        if(n == 0) head = head.next;
        else left.next = left.next.next;
        
        return head;
    }
}