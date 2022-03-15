using System.Collections;
using System.Collections.Generic;

namespace Unique;

public class UniqueCollection<T> : ICollection<T>
{
    List<T> myList;
    public int Count { get { return myList.Count; } }
    public bool IsReadOnly { get { return false; } }

    public UniqueCollection()
    {
        myList = new List<T>();
    }

    public void Add(T item)
    {
        if (!Contains(item))
        {
            myList.Add(item);
            System.Console.WriteLine($"{item} have been added to the collection.");
        }
        else
        {
            System.Console.WriteLine($"\n{item} is already exists in the collection.");
        }
    }
    public void Clear()
    {
        myList.Clear();
    }
    public bool Contains(T item)
    {
        return myList.Contains(item);
    }
    public void CopyTo(T[] array, int arrayIndex)
    {

        myList.CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return myList.GetEnumerator();

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return myList.GetEnumerator();
    }
    public bool Remove(T item)
    {
        return myList.Remove(item);

    }

    public override string ToString()
    {
        string s1 = "";
        foreach (var item in myList)
        {
            s1 = s1 + item.ToString() + "\n";
        }
        return s1;
    }

}