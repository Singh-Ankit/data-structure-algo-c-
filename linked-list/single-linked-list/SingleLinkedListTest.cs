using System;
using System.Collections.Generic;
using Xunit;

/// <summary>
/// Implements UNIT Test for linkedlist
/// </summary>
public class SingleLinkedListTest
{
	[Fact]
	public void TestAddFirst()
    {
		LinkedList<String> inputList = new LinkedList<string>();
		inputList.AddFirst("successfull!");
		inputList.AddFirst("is");
		inputList.AddFirst("Test");
		String input_str = "";
		foreach (string str in inputList)
		{
			input_str = input_str + " " + str;
		}

		var singleLinkedList = new SingleLinkedList.SingleLinkedList();
		singleLinkedList.addFirst("successfull!");
		singleLinkedList.addFirst("is");
		singleLinkedList.addFirst("Test");
		String output_str = singleLinkedList.printListForUnitTest();
        Assert.Equal(input_str, output_str);
    }

}
