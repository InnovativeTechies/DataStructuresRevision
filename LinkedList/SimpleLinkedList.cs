using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{

    public class Node
    {
        public object data { get; set; }
        public Node nextNode = null;
    }
    public class SimpleLinkedList
    {
        Node Head = null;
        Node Tail = null;
        public void AddToLinkedListLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if (Head==null)
            {
                
                
                Head = newItem;
                Tail = newItem;
                

            }
            else
            {

                Tail.nextNode = newItem;
                Tail = newItem;
               
            }
        }

        public void AddToLinkedListFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            newItem.nextNode = Head;
            Head = newItem;
        }

        public void ReadAll()
        {
            Node current = Head;
            while (current.nextNode!=null)
            {
                Console.WriteLine(current.data);
                current = current.nextNode;
                
               
            }
            Console.WriteLine(current.data);
        }

    }
}
