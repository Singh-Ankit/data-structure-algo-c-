using System;

namespace SingleLinkedList
{
	public interface ISingleLinkedList
	{
		//Add First
		public void addFirst(String data);

		//Add last | Insertion
		public void addLast(String data);

		//Print List | Traversal
		public void printList();

		//Delete List
		public void deleteFirst();

		//Delete
		public void deleteLast();

		//Length of linkedList
		public void size();

		public string printListForUnitTest();
	}
}
