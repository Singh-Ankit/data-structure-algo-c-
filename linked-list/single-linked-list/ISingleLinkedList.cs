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

		public string printListForUnitTest();
	}
}
