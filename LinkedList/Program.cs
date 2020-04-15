using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            SimpleLinkedList<int> simple = new SimpleLinkedList<int>();
            simple.AddToLinkedListLast(1);
            simple.AddToLinkedListLast(2);
            simple.AddToLinkedListLast(3);
            simple.AddToLinkedListLast(4);
            simple.AddToLinkedListLast(5);
            simple.AddToLinkedListFirst(6);

            simple.ReadAll();

            DoubleLinkedListDemo<int> doubleList = new DoubleLinkedListDemo<int>();

            doubleList.AddToLast(1);

            doubleList.AddToLast(2);

            doubleList.AddToLast(3);

            doubleList.ReadAllForward();
            doubleList.ReadReverse();

        }


    }
}
