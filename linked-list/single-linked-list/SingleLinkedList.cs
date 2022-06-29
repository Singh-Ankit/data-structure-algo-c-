using System;

namespace SingleLinkedList
{
    public class SingleLinkedList : ISingleLinkedList
    {
        public Node head { get; set; }
        //::::::::::::::::::::::::::::::: CREATE A NODE ::::::::::::::::::::::::::::::::::::::::::::::::::::
        //Node is a building block of LinkedList where it stores data and details of next Node 
        public class Node
        {
            //stores data
            public string data { get; set; }
            //stores node details
            public Node next { get; set; }

            //initialise a node
            public Node(string data)
            {
                this.data = data;
                //BY DEFAULT: whenever a new node is created, it's next is always null. This means that it's just a single node not a list of nodes
                this.next = null;
            }
        }
        //:::::::::::::::::::::::::::::: NODE CREATION DONE! :::::::::::::::::::::::::::::::::::::::::::::::

        /// <summary>
        /// Create a new node to add.
        /// CHECK: Is there any existing LinkedList? HOW TO CHECK: by checking if HEAD is null
        /// if HEAD is null, means there is no existing linkedlst. Simply use newly created Node above and set it as a HEAD. 
        /// else set next of newNode as HEAD and HEAD as newNode. Now our HEAD will keep pointing to newNode
        /// </summary>
        /// <param name="data"></param>
        public void addFirst(string data)
        {
            Node newNode = new Node(data);
            //check if LinkedList has no node
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.next = head;
            head = newNode;
        }

        /// <summary>
        /// First TRAVERSE linkedList until you find a node which points to null (i.e next of last node points to null)
        /// Now,simply update next of existing last node to our new node and new node points to null.
        /// </summary>
        /// <param name="data"></param>
        public void addLast(String data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }
            else
            {
                // Node traversal
                // create 'currentNode' as traversal node, assign HEAD as it's value. So, now currentNode points to HEAD
                // Why we need currentNode? it is bcoz if we directly use head to loop we will update our head and this 
                // will lead to loss of nodes in linkedlit
                Node currentNode = head;
                // loop - will reach to last node when next of 'currentNode' is null
                while (currentNode.next != null)
                {
                    // INCREMENT counter : set 'currentNode' as next of currentNode and continue traversal until next is null
                    currentNode = currentNode.next;
                }
                // when it's last node, i.e currentNode.next is null.Simply add a new node to last.
                // also, next of newNode is already null
                currentNode.next = newNode;
            }

        }

        /// <summary>
        /// Take 'currentNode' as tyoe of node and assign value of head. To start traversal from beginning
        /// print values until current node is not null
        /// </summary>
        public void printList()
        {
            Node currentNode = head;

            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // don't use 'currentNode.next' not equal to null. This won't print last element in the list
            // while(currentNode.next != null)
            while (currentNode != null)
            {
                Console.Write(currentNode.data + " -> ");
                currentNode = currentNode.next;
            }
            // when it's last node, i.e currentNode.next is null.Simply print NULL.
            Console.WriteLine("NULL");
        }

        public string printListForUnitTest()
        {
            Node currentNode = head;

            if (head == null)
            {
                return "List is empty";
            }

            // don't use 'currentNode.next' not equal to null. This won't print last element in the list
            // while(currentNode.next != null)
            String result = String.Empty;
            while (currentNode != null)
            {
                //Console.Write(currentNode.data + " ");
                result += " " + currentNode.data;
                currentNode = currentNode.next;
            }
            return result;
            // when it's last node, i.e currentNode.next is null.Simply print NULL.
            //Console.Write("NULL");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            SingleLinkedList linkedlist = new SingleLinkedList();
            linkedlist.addFirst("Isn't");
            linkedlist.addFirst("this");
            linkedlist.addLast("fantastic!");
            linkedlist.printList();
            //linkedlist.printListForUnitTest();
            Console.WriteLine(linkedlist.printListForUnitTest());
            Console.ReadLine();
        }
    }
}