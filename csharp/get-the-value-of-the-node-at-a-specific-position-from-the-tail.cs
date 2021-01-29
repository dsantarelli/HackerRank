// Complete the getNode function below.

/*
 * For your reference:
 *
 * SinglyLinkedListNode {
 *     int data;
 *     SinglyLinkedListNode next;
 * }
 *
 */
static int getNode(SinglyLinkedListNode head, int positionFromTail) {

	var values = new List<int>();
	var node = head;
	while (node != null) {
		values.Add(node.data);
		node = node.next;
	}
	values.Reverse();
	return values.Skip(positionFromTail).Take(1).Single();
}
