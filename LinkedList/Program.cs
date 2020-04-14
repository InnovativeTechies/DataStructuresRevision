using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList sl = new SimpleLinkedList();

            sl.AddToLinkedListLast(1);
            sl.AddToLinkedListLast(2);
            sl.AddToLinkedListLast(3);
            sl.AddToLinkedListLast(4);

            sl.ReadAll();
            Console.ReadLine();

        }
    }
}
