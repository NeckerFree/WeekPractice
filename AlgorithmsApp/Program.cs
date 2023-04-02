//using AlgorithmsApp;

//int[] array = new int[] { 3, 56, 73, 6, 75, 7, 3, 566, 88, 3, 64, 64, 64, 78, 3, 22, 45, 67, 7 };
//Bubble.Sort(ref array);
//Console.WriteLine(string.Join(" ", array));


//StackEx se=new StackEx();

//QueueEx queueEx = new QueueEx();

//LinkedListEx linkedListEx=new LinkedListEx();

//HashtableEx hashtableEx = new HashtableEx();

//BinarySearchEx binarySearchEx = new BinarySearchEx();

//SortedListEx sortedListEx = new SortedListEx();

//using AlgorithmsApp;
//SingleLinkedList singleLinkedList = new SingleLinkedList();
//singleLinkedList.head = null;
//singleLinkedList.Push(10);
//singleLinkedList.Push(20);
//singleLinkedList.Push(30);
//singleLinkedList.Push(40);
////singleLinkedList.Print(singleLinkedList.head);
//singleLinkedList.Delete(ref singleLinkedList.head, 30);
//singleLinkedList.Delete(ref singleLinkedList.head, 10);
//singleLinkedList.Delete(ref singleLinkedList.head, 20);
//singleLinkedList.Delete(ref singleLinkedList.head, 44);
//singleLinkedList.Print(singleLinkedList.head);


//using AlgorithmsApp;

//LinkedListCol<string> ll = new LinkedListCol<string>();
//ll.Add("First");
//ll.Add("Second");
//ll.Add("Third");
//ll.Add("Fouth");
//ll.Remove("Second");
//var response= ll.Contains("First");
//var response2 = ll.Contains("Second");
//var cant = ll.Count;

//foreach (string word in ll)
//{
//    Console.WriteLine(word);
//}

//ll.Clear();

//using AlgorithmsApp.Inheritance;

//Transport transport = new Transport();
//Airplane airplane = new Airplane();
//Transport airplaneAsTransport = new Airplane();

//transport.Move(); // Transport - Move 
//transport.Carry(); // Transport - Carry
//airplane.Move(); // Airplane - Move 
//airplane.Carry(); // Airplane - Carry
//airplaneAsTransport.Move(); // Airplane - Move 
//airplaneAsTransport.Carry(); // Transport - Carry

using AlgorithmsApp.Classes;
int times = Recursion.Calculate(100, 765,true);
//int times = Recursion.Calculate(100000, 456669);
//int times = Recursion.Calculate(567, 768);
//int times = Recursion.Calculate(5, 4);
//int times = Recursion.Calculate(32, 45);
Console.WriteLine($"executed times: {times}");
Console.ReadKey();


