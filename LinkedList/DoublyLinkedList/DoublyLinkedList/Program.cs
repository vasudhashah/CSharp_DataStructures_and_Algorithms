public class Node
{
    public Node next;
    public Node prev;
    public int element;

    public Node(Node next, Node prev, int element)
    {
        this.next = next;
        this.prev = prev;
        this.element = element;
    }
}

class DoublyLinkedList
{
    private Node head;
    private Node tail;
    private int size;

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
        size = 0;
    }

    public int length()
    {
        return size;
    }

    public bool isEmpty()
    {
        return size == 0;
    }
    
    public void addLast(int element)
    {
        Node newest = new Node(null, null, element);
        if (isEmpty())
        {
            head = newest;
            tail = newest;
        }
        else
        {
            tail.next = newest;
            newest.prev = tail;
            tail = newest;
        }
        size = size + 1;
    }
    public void display()
    {
        Node p = head;
        while (p != null)
        {
            Console.Write(p.element + "-->");
            p = p.next;
        }
        Console.WriteLine();
    }
    public void addFirst(int e)
    {
        Node newest = new Node(null, null,e);
        if (isEmpty())
        {
            head = newest;
            tail = newest;
        }
        else
        {
            newest.next = head;
            head.prev = newest;
            head = newest;
        }
        size = size + 1;
    }

    public void addAny(int e, int position)
    {
        if (position <= 0 || position >= size)
        {
            Console.WriteLine("Invalid Position");
            return;
        }
        Node newest = new Node(null, null,e);
        Node p = head;
        int i = 1;
        while (i < position - 1)
        {
            p = p.next;
            i = i + 1;
        }
        newest.next = p.next;
        p.next.prev = newest;
        p.next = newest;
        newest.prev = p;
        size = size + 1;
    }

    public int removeFirst()
    {
        if (isEmpty())
        {
            Console.WriteLine("Doubly List is Empty");
            return -1;
        }
        int e = head.element;
        head = head.next;
        size = size - 1;
        if (isEmpty())
            tail = null;
        else
            head.prev = null;
        return e;
    }

    public int removeLast()
    {
        if (isEmpty())
        {
            Console.WriteLine("Doubly List is Empty");
            return -1;
        }
        int e = tail.element;
        tail = tail.prev;
        tail.next = null;
        size = size - 1;
        return e;
    }

    public int removeAny(int position)
    {
        if (position <= 0 || position >= size - 1)
        {
            Console.WriteLine("Invalid Position");
            return -1;
        }
        Node p = head;
        int i = 1;
        while (i < position - 1)
        {
            p = p.next;
            i = i + 1;
        }
        int e = p.next.element;
        p.next = p.next.next;
        p.next.prev = p;
        size = size - 1;
        return e;
    }

    public static void Main(string[] args)
    {
        DoublyLinkedList d = new DoublyLinkedList();
        d.addLast(7);
        d.addLast(4);
        d.addFirst(12);
        d.display();
        d.addAny(20, 3);
        d.display();
        int element = d.removeFirst();
        Console.WriteLine("Removed Element: " + element);
        int element3 = d.removeLast();
        Console.WriteLine("Removsed Element: " + element3);
        int element1 = d.removeAny(3);
        Console.WriteLine("Removed Element: " + element1);
        Console.WriteLine("Size: " + d.length());

    }
}