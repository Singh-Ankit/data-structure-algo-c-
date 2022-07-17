using System;

namespace double_linked_list
{
    public class DoubleLinkedList
    {
        public Node head { get; set; }
        public class Node
        {
            public int data { get; set; }
            public Node next { get; set; }
            public Node prev { get; set; }

            public Node(int data)
            {
                this.data = data;
                this.next = null;   
                this.prev = null;
            }

        }

        public void InsertFirst(int data)
        {
            //creating new node for insertion 
            Node newNode = new Node(data);
            if (head == null)
            {
                Console.WriteLine("Double Linked List is empty!! creating new node...");
                head = newNode;
                return;
            }
            newNode.next = head;
            head.prev = newNode;
            newNode.prev = null;
            head = newNode;
        }

        public void InsertLast(int data)
        {
            Node newNode = new Node(data);
            Node lastNode = null;
            var curr = head;

            while (curr != null)
            {
                //updating current visitied node here, this will help us in getting last node before null
                lastNode = curr;
                // this is to increment value of node for traversal
                curr = curr.next;
            }

            //previously what was last node pointing to null, now it's next will ne newNode insetead of null. 
            lastNode.next = newNode;
            //Since, our newNode becomes lastnode, so it's next will be null
            newNode.next = null;
            //previous of newly added lastnode will be pointing to previos last node
            newNode.prev = lastNode;
        }

        public void PrintList()
        {
            var curr = head;
            if(head == null)
            {
                Console.WriteLine("list is empty!!");
                return;
            }

            if(head.next != null)
            {
                Console.WriteLine("single element");
            }
            while(curr !=null)
            {
                Console.WriteLine(curr.data + "->");
                Console.WriteLine( " <- ");
                curr = curr.next;
            }
        }
    }
}
