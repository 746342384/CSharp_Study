namespace 链表;

public class LinkList<T>
{
    public Node<T> Head;

    public void Add(T value)
    {
        var node = new Node<T>(value);
        if (Head == null)
        {
            Head = node;
        }
        else
        {
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
        }
    }

    public void Remove(T value)
    {
        if (Head == null) return;
        if (Head.Value.Equals(value))
        {
            Head = Head.Next;
        }
        else
        {
            var current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next;
                    return;
                }

                current = current.Next;
            }
        }
    }
}