using System;

namespace SingleLinkedList
{
    public class SingleLinkedList : ISingleLinkedList
    {
        public Node head { get; set; }
        static int linkedListSize { get; set; }
        static SingleLinkedList ()
	    {
            linkedListSize = 0;
	    }

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
               linkedListSize++;
            }
            
        }
        //:::::::::::::::::::::::::::::: NODE CREATION DONE! :::::::::::::::::::::::::::::::::::::::::::::::

        /// <summary>
        /// Inserts node at beginning
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
        /// Insert node at end
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

        /// <summary>
        /// Delete node at beginning.
        /// Point current head to next node
        /// </summary>
        /// <returns></returns>
        public void deleteFirst()
        {
            //check for if list is empty
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            head = head.next;
            linkedListSize--;
        }

        public void deleteLast()
        {
            //CORNER case: 1
            if (head == null)
            {
                Console.WriteLine("List is null");
                return ;
            }
            linkedListSize--;
            //CORNER case: 2
            if(head.next == null)
            {
                // means there is only one element in linkedlist. Hence make head as null to delete
                head = null;
            }

            Node secondLastNode = head;
            //if above node is the secondLastNode with value of Head. Then, next node will be surely last node
            Node lastNode = head.next; //if head.next == null --means it's--> last node
            //Iterate until you get next of last node as null 
            while(lastNode.next != null) // null.next == null  and null.next != null give exception
            {
                lastNode = lastNode.next;
                secondLastNode = secondLastNode.next;
            }

            //make next of second last as null
            secondLastNode.next = null;
        }

        public void size()
        {
            Console.WriteLine(linkedListSize);
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
            linkedlist.addLast("yes");
            linkedlist.printList();
            //linkedlist.printListForUnitTest();
            //Console.WriteLine(linkedlist.printListForUnitTest());
            linkedlist.deleteFirst();
            linkedlist.printList();
            linkedlist.deleteLast();    
            linkedlist.printList();
            linkedlist.size();
        }
    }
}