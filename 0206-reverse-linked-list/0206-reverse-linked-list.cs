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
 *
 * head = 2, head.next= 3
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null) return head;
        
        ListNode first = null;
        ListNode second = null;
        
        while(head != null){
            second = head.next;
            head.next = first;
            first = head;
            head = second;
        }
        
        return first;
    }
}