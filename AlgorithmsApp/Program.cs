//using AlgorithmsApp;

//int[] array = new int[] { 3, 56, 73, 6, 75, 7, 3, 566, 88, 3, 64, 64, 64, 78, 3, 22, 45, 67, 7 };
//Bubble.Sort(ref array);
//Console.WriteLine(string.Join(" ", array));
using AlgorithmsApp;

//StackEx se=new StackEx();

//QueueEx queueEx = new QueueEx();

//LinkedListEx linkedListEx=new LinkedListEx();

//HashtableEx hashtableEx = new HashtableEx();

//BinarySearchEx binarySearchEx = new BinarySearchEx();

//SortedListEx sortedListEx = new SortedListEx();

SingleLinkedList singleLinkedList = new SingleLinkedList();
singleLinkedList.head = null;
singleLinkedList.Push(10);
singleLinkedList.Push(20);
singleLinkedList.Push(30);
singleLinkedList.Push(40);
//singleLinkedList.Print(singleLinkedList.head);
singleLinkedList.Delete(ref singleLinkedList.head, 30);
singleLinkedList.Delete(ref singleLinkedList.head, 10);
singleLinkedList.Delete(ref singleLinkedList.head, 20);
singleLinkedList.Delete(ref singleLinkedList.head, 44);
singleLinkedList.Print(singleLinkedList.head);



