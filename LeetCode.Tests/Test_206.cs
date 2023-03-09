namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_206
{
    private ReverseLinkedList _solution;
    [SetUp]
    public void Setup()
    {
        _solution = new ReverseLinkedList();
    }

    [Test]
    public void Test1()
    {
        ListNode node1 = new ListNode(1);
        ListNode node2 = new ListNode(2);
        ListNode node3 = new ListNode(3);
        ListNode node4 = new ListNode(4);
        ListNode node5 = new ListNode(5);
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;
        node5.next = null;
    }
}