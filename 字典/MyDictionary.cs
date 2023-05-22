namespace MyDictionary;

public class MyDictionary<Tkey, TValue>
{
    private class Entry
    {
        public Tkey Key;
        public TValue Value;
        public Entry Next;
    }

    private const int DeraultCapacity = 4;
    private int _capacity;
    private int _count;
    private Entry[] _buckets;

    public MyDictionary()
    {
        _capacity = DeraultCapacity;
        _buckets = new Entry[_capacity];
    }

    public void Add(Tkey key, TValue value)
    {
        if (_count == _capacity)
        {
            Resize();
        }

        var hash = GetHash(key);
        var entry = new Entry { Key = key, Value = value };
        if (_buckets[hash] == null)
        {
            _buckets[hash] = entry;
        }
        else
        {
            var current = _buckets[hash];
            while (current.Next != null)
            {
                if (current.Key.Equals(key))
                {
                    throw new ArgumentException("添加了相同的key");
                }

                current = current.Next;
            }

            if (current.Key.Equals(key))
            {
                throw new ArgumentException("添加了相同的key");
            }

            current.Next = entry;
        }

        _count++;
    }

    public TValue Get(Tkey key)
    {
        var hash = GetHash(key);
        var current = _buckets[hash];
        while (current != null)
        {
            if (current.Key != null && current.Key.Equals(key))
            {
                return current.Value;
            }

            current = current.Next;
        }

        throw new ArgumentException($"not found key {key?.ToString()}");
    }

    public void Remove(Tkey key)
    {
        var hash = GetHash(key);
        var current = _buckets[hash];
        Entry previous = null;

        while (current != null)
        {
            if (current.Key.Equals(key))
            {
                if (previous == null)
                {
                    _buckets[hash] = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                }

                _count--;
                return;
            }

            previous = current;
            current = current.Next;
        }

        throw new ArgumentException("remove not fount key");
    }

    private void Resize()
    {
        _capacity *= 2;
        var newBuckets = new Entry[_capacity];
        foreach (var oldBucket in _buckets)
        {
            var current = oldBucket;
            while (current != null)
            {
                var hash = GetHash(current.Key);
                var newEntry = new Entry { Key = current.Key, Value = current.Value };
                if (newBuckets[hash] == null)
                {
                    newBuckets[hash] = newEntry;
                }
                else
                {
                    var newCurrent = newBuckets[hash];
                    while (newCurrent.Next != null)
                    {
                        newCurrent = newEntry.Next;
                    }

                    newCurrent.Next = newEntry;
                }

                current = current.Next;
            }
        }

        _buckets = newBuckets;
    }

    private int GetHash(Tkey key)
    {
        return key.GetHashCode() % _capacity;
    }
}