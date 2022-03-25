namespace Cll;

public class Node<T>
{

    public Node<T>? Prev;
    public T Value;
    public Node<T>? Next;


    public Node(Node<T>? Prev, T Value, Node<T>? Next)
    {
        this.Prev = Prev;
        this.Value = Value;
        this.Next = Next;
    }

}