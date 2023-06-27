using AlgorithmsApp.BigNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsApp.LinkedList
{
    public static class SingleLinkedListLet
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l1Reversed = ReverseList(l1);
            ListNode l2Reversed = ReverseList(l2);
            string value1 = RecoverValues(l1Reversed);
            string value2 = RecoverValues(l2Reversed);
            string sum =BigNumbersOperations.Sum(value1, value2);
            var result = sum.Reverse<char>().ToList();
            ListNode head = new ListNode(int.Parse(result[0].ToString()));
            ListNode current = head;
            for (int i = 1; i < result.Count; i++)
            {
                ListNode newNode = new ListNode(int.Parse(result[i].ToString()));
                current.next = newNode;
                current = newNode;
            }
            return head;
        }

        private static ListNode ReverseList(ListNode node)
        {
            var head = node;
            if (head == null || (head.next == null)) return head;
            var res = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return res;
        }
        private static string RecoverValues(ListNode node)
        {
            StringBuilder response = new StringBuilder();
            ListNode current = node;
            response.Append(current.val);
            while (current.next != null)
            {
                current = current.next;
                response.Append(current.val);
            }

            return response.ToString();
        }
        
    }
}
