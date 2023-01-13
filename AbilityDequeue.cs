﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class AbilityDequeue
    {
        public Node head;
        public Node tail;
        public int count;
        public AbilityDequeue()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;

        }
        public void enqueue(int value) //Add new node in Queue.
        {
            Node node = new Node(value); //Create new Node.
            if (head == null)
            {
                head = node; //Add 1st element in Queue.
            }
            else
            {
                tail.next = node;
            }
            Console.WriteLine("The Data is : " + node.data);
            this.count++;
            this.tail = node;
        }

        public int dequeue() //Delete element from Queue
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
                return 0;
            }

            var temp = head;
            head = head.next;
            this.count--;
            if (head == null)
            {
                tail = null; //when deleting the last node of linked list.
            }

            return temp.data;
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
