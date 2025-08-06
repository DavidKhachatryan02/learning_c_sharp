public class Node
{
    public int Value;
    public Node Next;
    public Node Previous;

    public Node Root;

    public Node(int value)
    {
        Value = value;
        Next = null;
        Previous = null;
        Root = null;
    }
}

public class CustomLinkedList
{
    public Node Head;
    public Node Tail;

    public CustomLinkedList()
    {
        Head = null;
        Tail = null;
    }

    public void Add(int value)
    {
        Node newNode = new Node(value);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Root = null;
            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }

        Tail.Root = Head;
    }

    public void PrintForward()
    {
        Console.WriteLine("Forward:");
        Node current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void PrintBackward()
    {
        Console.WriteLine("Backward:");
        Node current = Tail;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Previous;
        }
        Console.WriteLine();
    }

    public void PrintFromLastToRoot()
    {
        if (Tail != null && Tail.Root != null)
        {
            Console.WriteLine($"Tail: {Tail.Value}, Root from Tail: {Tail.Root.Value}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        CustomLinkedList list = new CustomLinkedList();

        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        list.PrintForward();
        list.PrintBackward();
        list.PrintFromLastToRoot();
    }
}