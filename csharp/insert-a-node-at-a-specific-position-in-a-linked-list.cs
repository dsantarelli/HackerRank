
  static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
  {
    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);    

    if (head == null) return newNode;
    else if (position == 0)
    {
      newNode.next = head;
      return newNode;
    }

    SinglyLinkedListNode currNode = head;

    for (int i = 0; i < position - 1; i++)    
      currNode = currNode.next;
    
    newNode.next = currNode.next;
    currNode.next = newNode;

    return head;

  }