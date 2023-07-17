using Stack_Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList stackUsingLinkedList = new StackUsingLinkedList();
            stackUsingLinkedList.Push(70);
            stackUsingLinkedList.Push(30);
            stackUsingLinkedList.Push(56);
            Console.WriteLine("Stack Structure- ");
            stackUsingLinkedList.Display();
            stackUsingLinkedList.IsEmpty();
            stackUsingLinkedList.Display();

            QueueUsingLinkedList queueUsingLL = new QueueUsingLinkedList();
            queueUsingLL.Enqueue(56);
            queueUsingLL.Enqueue(30);
            queueUsingLL.Enqueue(70);
            Console.WriteLine("Queue Structure- ");
            queueUsingLL.Display();
            Console.ReadLine();
        }
    }
}