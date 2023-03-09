namespace LeetCode.Solutions.Solutions;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class ReverseLinkedList {
    public ListNode Solution(ListNode head)
    {
        ListNode newHead = null;
        while(head!=null)
        {
            ListNode next = head.next;
            head.next = newHead;
            newHead = head;
            head = next;
        }
        return newHead;
    }
    
}