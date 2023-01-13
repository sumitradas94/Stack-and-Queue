namespace StackQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Welcome to Data structure Problem");
            /*CreateStack obj = new CreateStack();
            Console.WriteLine("After push the elements are :- ");

            obj.push(70);
            obj.push(30);
            obj.push(56);
            Console.WriteLine();*/


            //PeakandPop obj = new PeakandPop();
            CreateQueue obj = new CreateQueue();
            Console.WriteLine("After Enqueue the elements are : ");

            obj.enqueue(70);
            obj.enqueue(30);
            obj.enqueue(56);
            Console.WriteLine("-------------------");

            //Console.WriteLine("Item popped from Queue = " + obj.dequeue());
            Console.WriteLine("Peek Element of the Queue is : " + obj.peek()); ;
        }
    }
}