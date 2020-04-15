using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{

    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> nextNode = null;
        public Node<T> prevNode = null;
    }
    public class SimpleLinkedList<T>
    {
        public Node<T> Head = null;
        public Node<T> Tail = null;
        public void AddToLinkedListLast(T data)
        {
            Node<T> newItem = new Node<T>();
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

        public void AddToLinkedListFirst(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            newItem.nextNode = Head;
            Head = newItem;
        }
      
        public void ReadAll()
        {
            Node<T> current = Head;
            while (current.nextNode!=null)
            {
                Console.WriteLine(current.data);
                current = current.nextNode;
                
               
            }
            Console.WriteLine(current.data);
        }

    }
}
