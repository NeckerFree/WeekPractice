using AlgorithmsApp;

namespace TestProject
{
    public class UnitTestGCD
    {
        [Theory]
        //[InlineData(121, 55, 11)]
        //[InlineData(2, 48, 2)]
        //[InlineData(48, 27, 3)]
        [InlineData(27, 48, 3)]
        public void FindGCD_BothPositives_GreatherThanZero(int a, int b, int result)
        {
            GCD gcd = new GCD();
            int response = gcd.Calculate(a, b);
            Assert.Equal(response, result);

        }

        [Fact]
        public void ValidateStackResult()
        {

            StackCol stack = new StackCol(10);


            stack.Push(99);
            var first = stack.Pop();
            stack.Push(99);
            stack.Push(88);
            stack.Push(77);
            stack.Push(66);
            stack.Push(55);
            stack.Push(44);
            stack.Push(33); 
            stack.Push(22);
            stack.Push(11);
            stack.Push(00);
            var element = stack.Pop();
            //Console.WriteLine(element);
            
            //Console.WriteLine(peek);

            stack.Pop();
            stack.Pop();
            stack.Pop();

            stack.Push(100);
            int peek = stack.Peek();
            //Console.WriteLine($"Size: {stack.Count}");
            string result= stack.Print();
            Assert.Equal("99 88 77 66 55 44 100 ", result);
        }

        [Fact]
        public void ValidateQueueResult()
        {
            QueueCol queue = new QueueCol(10);
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");
            queue.Dequeue();
            queue.Enqueue("Five");
            queue.Enqueue("Six");
            queue.Enqueue("Seven");
            queue.Dequeue();
            string actual = queue.Print();
            Assert.Equal("Three Four Five Six Seven ", actual);

        }
    }
}