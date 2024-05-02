namespace LeetCode.Solutions.Solutions;

public class MiddleOfLinkedListSolution
{
    public List<int> MiddleNode(List<int> head)
    {
        head.RemoveRange(0, head.Count / 2);
        return head;
    }
}