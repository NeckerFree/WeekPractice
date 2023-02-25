using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic.FileIO;

namespace AlgorithmsApp
{
    //LinkedList It is basically chains of nodes, each node contains information such as data 
    //and a pointer to the next node in the chain.In the linked list there is a head pointer, 
    //which points to the first element of the linked list, and if the list is empty 
    //then it simply points to null or nothing.
    public class SingleLinkedList
    {
        public Node? head;
        /// <summary>
        /// Insert at the begining
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }
        /// <summary>
        /// Insert at the end
        /// </summary>
        /// <param name="data"></param>
        public void Append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.next = null;
            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = newNode;
            return;

        }
        public void InsertAfter(Node previousNode, int data)
        {
            if (previousNode==null)
            {
                Console.WriteLine("Previous node can´t be null");
                return;
            }
            Node newNode = new Node(data);
            newNode.next =previousNode.next;
            previousNode.next = newNode;
        }
        public void Delete(ref Node? head, int val)
        {
            if (head == null)
            {
                Console.WriteLine("Invalid Operation");
                return ;
            }
            if (head.Data== val)
            {
                Node? temp= head;
                head = head.next;
                temp = null;
                return;
            }
            Delete(ref head.next, val);
        }

        public void Print(Node? head)
        {
            if (head == null)
            {
                Console.WriteLine();
                return ;
            }
            Console.WriteLine(head.Data + " ");
            Print(head.next);
        }
    }
}
