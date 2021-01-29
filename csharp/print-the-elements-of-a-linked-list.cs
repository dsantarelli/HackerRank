static void printLinkedList(SinglyLinkedListNode head)
{
	SinglyLinkedListNode node = head;
	while (node != null)
	{
	  Console.WriteLine(node.data);
	  node = node.next;
	}
}