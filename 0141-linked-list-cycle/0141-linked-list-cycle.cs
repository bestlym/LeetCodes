/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        
        var hs = new HashSet<ListNode>();
        
        while(head != null){
            if(!hs.Add(head.next)) return true;
            head = head.next;
        }
        
        return false;
    }
}




