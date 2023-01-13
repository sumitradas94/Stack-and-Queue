using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackQueue
{
    public class CreateStack
    {
        Node head;
        public void push(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                node.next = temp;
            }
            Console.WriteLine("Element pushed into stack is " + data);
        }

        public int pop()
        {
            int popped;
            if (head == null)
            {
                Console.WriteLine("Stack is Empty");
                return 0;
            }
            else
            {
                popped = head.data;
                head = head.next;
                return popped;
            }
        }

        public int peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                return head.data;
            }
        }
    }
}
