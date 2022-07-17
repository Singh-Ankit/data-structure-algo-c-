using System;

namespace double_linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
            doubleLinkedList.InsertFirst(3);
            doubleLinkedList.InsertFirst(2);
            doubleLinkedList.InsertFirst(1);
            Console.WriteLine("Head of new linkedlist is: "+doubleLinkedList.head.data);

            doubleLinkedList.PrintList();
            doubleLinkedList.InsertLast(4);
            Console.WriteLine("----------------");
            doubleLinkedList.PrintList();
        }
    }
}
