/*
 * @lc app=leetcode id=83 lang=csharp
 *
 * [83] Remove Duplicates from Sorted List
 */

// @lc code=start
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
        ListNode temp = head;
        while(temp != null)
        {
            while (temp.next != null && temp.val == temp.next.val) 
            {
                temp.next=temp.next.next;
            }
            
            temp = temp.next;
        }
        
        return head;
    }
}
// @lc code=end

