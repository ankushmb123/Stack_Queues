using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queues
{
    class Node
    {
        // Node is an element of linkedlist that hold data and address of next node.

        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
}