using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queues
{
    // Implenting Stack using LinkedList.
    class StackUsingLinkedList
    {
        private Node top;
        public StackUsingLinkedList()
        {
            this.top = null;
        }
        // Pushing data to the top of stack.      
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        // peek from the stack

        public void Peek()
        {
            //if top is null
            if (this.top == null)
            {
                //stack is empty
                Console.WriteLine("Stack is empty");
                return;
            }
            // value is in the top of the stack
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);
        }
        //  Pop from the stack 
        public void Pop()
        {
            //if top is null
            if (this.top == null)
            {
                // stack is empty 
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            //otherwise value is popped is value
            Console.WriteLine("Value popped is {0} ", this.top.data);
            //next 
            this.top = this.top.next;
        }
        // is empty        
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        // method to display all the elements of stack.

        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}