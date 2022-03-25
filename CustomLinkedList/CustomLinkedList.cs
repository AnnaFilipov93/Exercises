using System.Collections;
namespace Cll;

public class CustomLinkedList<T>
{
    public Node<T>? First;
    private Node<T>? Current;
    public Node<T>? Last;

    public CustomLinkedList()
    {
        Current = null;
    }

    public void Add(T item)
    {
        Last = new Node<T>(Current, item, null);

        if (Current == null)
        {
            First = Last;
        }
        else
        {
            Current.Next = Last;
        }

        Current = Last;

    }

    public IEnumerator GetEnumerator()
    {

        Node<T>? Iterator = First;

        while (Iterator != null)
        {
            yield return Iterator.Value;
            Iterator = Iterator.Next;
        }
    }

    public IEnumerable GetEnumerableDESC()
    {
        Node<T>? Iterator = Last;

        while (Iterator != null)
        {
            yield return Iterator.Value;
            Iterator = Iterator.Prev;
        }
    }




}