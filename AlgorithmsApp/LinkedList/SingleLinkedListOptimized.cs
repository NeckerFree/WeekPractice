using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsApp.LinkedList
{
    namespace AlgorithmsApp.LinkedList
    {
        public static class SingleLinkedListOptimized
        {
            public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode dummy = new ListNode();
                ListNode current = dummy;
                int carry = 0;

                while (l1 != null || l2 != null || carry != 0)
                {
                    int sum = carry;

                    if (l1 != null)
                    {
                        sum += l1.val;
                        l1 = l1.next;
                    }

                    if (l2 != null)
                    {
                        sum += l2.val;
                        l2 = l2.next;
                    }

                    carry = sum / 10;
                    int valueToStore = sum % 10;
                    current.next = new ListNode(valueToStore);
                    current = current.next;
                }

                return dummy.next;
            }
        }
    }
}
