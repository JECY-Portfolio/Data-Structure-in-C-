
public class Stack <T>
{
    public LinkedList<T> linkedList = new LinkedList<T>();

    public bool IsEmpty()
    {
        return linkedList.Size() == 0;
    }
    public void Push(T item)
    {
        linkedList.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("The Stack is Empty");
        T item = Peek();
        linkedList.Remove(item);
        return item;
    }
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        LinkedList<T>.Node current = linkedList.LastNode();
        return current.Data;
    }

    public int Size()
    {
        return linkedList.Size();
    }

}
