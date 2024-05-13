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
    public ListNode DeleteDuplicates(ListNode head) {
        var slow = head;
        var fast = head?.next;
        
        while(slow?.next != null)
        {
           if(slow.val == fast.val){
               slow.next = fast.next;
               fast.next = null;
               fast = slow.next;               
           } else {
               slow = fast;
               fast = fast?.next;
           }
        }
        return head;
    }
}