// Complete the insertNodeAtTail function below.

/*
 * For your reference:
 *
 * SinglyLinkedListNode {
 *     int data;
 *     SinglyLinkedListNode next;
 * }
 *
 */
static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
{
	var node = head;
	while (node != null)
	{
	  if (node.next == null)
	  {
		node.next = new SinglyLinkedListNode(data);
		return head;
	  }
	  node = node.next;
	}
	return new SinglyLinkedListNode(data);
}

