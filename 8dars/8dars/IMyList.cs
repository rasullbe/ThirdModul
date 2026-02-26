namespace _8dars;

public interface IMyList<T>
{
    public void Add(T item);
    public bool RemoveAll(T item);
    public bool RemoveAt(int index);
    public bool Contains(T item);
    public int IndexOf(T item);
    public T GetById(int index);
    public void DisplayElements();
}