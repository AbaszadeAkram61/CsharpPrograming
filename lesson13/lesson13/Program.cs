using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main1(string[] args)
    {
        //Create new MyList class from scratch, which work mostly as List.It hsould have void Add(T item), void Remove(T item), void Clear(), bool
        // Contains(T item) methods and Count poperty. We also can iterate this collection via foreach

        Mylist<int> mylist = new Mylist<int>();
        mylist.Add(2);
        mylist.Add(3);
        mylist.Add(5);
        
        foreach (var item in mylist)
        {
            Console.WriteLine(item);
        }

    }
}
public class Mylist<T>:IEnumerable<T>
{
    public int Count
    {
        get
        {
            return items.Count;
        }
    }
    private List<T> items;
    public void Add(T item)
    {
        items.Add(item);
    }
    public void Remove(T item)
    {
        items.Remove(item);
    }
    public void Clear()
    {
        items.Clear();
    }
    public bool Contains(T item)
    {
        return items.Contains(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}