using AlgorithmsApp.LinkedList;
using AlgorithmsApp.LinkedList.AlgorithmsApp.LinkedList;

namespace TestProject
{
    public class SingleLinkedListTests
    {
        [Fact]
        public void ValidateSingleLinkedList()
        {

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            ListNode expected = new ListNode(7);
            expected.next = new ListNode(0);
            expected.next.next = new ListNode(8);
            ListNode actual = SingleLinkedListOptimized.AddTwoNumbers(l1, l2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateSingleLinkedListBigNum()
        {

            ListNode l1 = new ListNode(9);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(9);
            l2.next.next = new ListNode(9);
            l2.next.next.next = new ListNode(9);
            l2.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next.next.next = new ListNode(9);

            ListNode expected = new ListNode(7);
            expected.next = new ListNode(0);
            expected.next.next = new ListNode(8);
            ListNode actual = SingleLinkedListOptimized.AddTwoNumbers(l1, l2);
            Assert.Equal(expected, actual);
        }
    }
}
