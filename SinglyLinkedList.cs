public class LinkedList<T>
{
    public class Node
    {
        public T Data;
        public Node Next;
        public Node(T item)
        {
            Data = item;
            Next = null;
        }
    }

    public Node head;

    public LinkedList()
    {
        head = null;
    }

    public int Add(T item)
    {
        Node newNode = new Node(item);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        
        return Size();
    }
    public bool Remove(T item)
    {
        if (head == null) return false;

        if (head.Data.Equals(item))
        {
            head = head.Next;
            return true;
        }

        Node current = head;
        while (current.Next != null && !current.Next.Data.Equals(item))
        {
            current = current.Next;

        }
        if (current.Next == null) return false;

        current.Next = current.Next.Next;
        return true;
    }
    public bool Check(T item)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data.Equals(item))
                return true;
            current = current.Next;
        }
        return false;
    }

    public int Index(T item)
    {
        int index = 0;
        Node current = head;

        while (current != null)
        {
            if (current.Data.Equals(item))
                return index;
            current = current.Next;
            index++;
        }
        return -1;
    }
    public int Size()
    {
        int size = 0;
        Node current = head;
        while (current != null)
        {
            size++;
            current = current.Next;
        }

        return size;
    }

    public Node LastNode()
    {
        if (head == null)
            throw new InvalidOperationException("List is empty.");

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        return current;
    }

}


