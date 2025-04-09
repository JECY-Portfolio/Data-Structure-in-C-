public class Queue<T>
{
    private LinkedList<T> linkedList = new LinkedList<T>();

    public bool IsEmpty()
    {
        return linkedList.Size() == 0;
    }

    public void Enqueue (T item)
    {
        linkedList.Add(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        T item = linkedList.head.Data;
        linkedList.Remove(item);
        return item;
    }

    public int Size()
    {
        return linkedList.Size();
    }
}