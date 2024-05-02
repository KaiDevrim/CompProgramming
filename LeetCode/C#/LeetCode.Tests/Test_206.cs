namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_206
{
    [SetUp]
    public void Setup()
    {
        _solution = new ReverseLinkedList();
    }

    private ReverseLinkedList _solution;

    [Test]
    public void Test1()
    {
        ListNode node1 = new(1);
        ListNode node2 = new(2);
        ListNode node3 = new(3);
        ListNode node4 = new(4);
        ListNode node5 = new(5);
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;
        node5.next = null;
    }
}