using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{

    public class DoubleLinkedListDemo<T>:SimpleLinkedList<T>
    {
        public Node<T> prev = null;
        public DoubleLinkedListDemo():base()
        {

        }

        public void AddToLast(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            if(Head==null)
            {
                Head = newItem;
                Tail = Head;
            }

            else
            {
                Tail.nextNode = newItem;
                newItem.prevNode = Tail;
                Tail = newItem;
            }
        }
        public void AddToDoubleLinkedListFirst(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            newItem.nextNode = Head;
            Head.prevNode = newItem;
            Head = newItem;
        }

        public void ReadAllForward()
        {
            Node<T> current = Head;
            while (current.nextNode != null)
            {
                Console.WriteLine(current.data);
                current = current.nextNode;


            }
            Console.WriteLine(current.data);
        }
        public void ReadReverse()
        {
            Node<T> current = Tail;
            while (current.prevNode != null)
            {
                Console.WriteLine(current.data);
                current = current.prevNode;


            }
            Console.WriteLine(current.data);
        }
    }
}
