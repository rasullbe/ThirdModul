namespace _8dars;

public class MyList<T> : IMyList<T>
{
    private T[] _items;
    private int _count = 0;

    public int Capacity => _items.Length;
    public int Count => _count;

    public MyList(int capacity = 4)
    {
        _items = new T[capacity];
    }

    public void Add(T item)
    {
        if (_count >= Capacity)
        {
            DoubleCapacity();
        }

        _items[_count] = item;
        _count++;
    }

    private void DoubleCapacity()
    {
        T[] newArr = new T[Capacity * 2];
        for (int i = 0; i < _count; i++)
        {
            newArr[i] = _items[i];
        }
        _items = newArr;
    }

    public bool Contains(T item)
    {
        return IndexOf(item) != -1;
    }

    public T GetById(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException();

        return _items[index];
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (Equals(_items[i], item))
            {
                return i;
            }
        }
        return -1;
    }

    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index == -1)
            return false;

        return RemoveAt(index);
    }

    public bool RemoveAll(T item)
    {
        bool removed = false;

        for (int i = 0; i < _count; i++)
        {
            if (Equals(_items[i], item))
            {
                RemoveAt(i);
                i--;
                removed = true;
            }
        }

        return removed;
    }

    public bool RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
            return false;

        for (int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _count--;
        _items[_count] = default!;
        return true;
    }

    public void DisplayElements()
    {
        for (int i = 0; i < _count; i++)
        {
            Console.Write(_items[i] + " ");
        }
    }
}