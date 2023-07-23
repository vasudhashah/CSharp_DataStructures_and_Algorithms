using System.Data.Common;

public class Node
{
    public int data;
    public Node next;

    public Node(int data, Node next)
    {
        this.data = data;
        this.next = next;
    }
}
public class LinkedListt
{
    private Node head;
    private Node tail;
    private int size;

    public LinkedListt()
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

    public void addNode(int data)
    {
        Node newNode = new Node(data, null);
        if (isEmpty())
            head = newNode;
        else
            tail.next = newNode;
        tail = newNode;
        size = size + 1;
        //time complexity of adding node in end is O(1)
    }
    public void AddNodeAtPosition(int data, int position)
    {
        Node newNode = new Node(data, null);
        if (isEmpty())
        {
            head = newNode;
            tail = newNode;
        }
        Node temp = head;
        for(int i = 1; i < position-1; i++)
        {
            temp = temp.next;
        }
        newNode.next = temp.next;
        temp.next = newNode;
        size = size + 1;
        //timeComplexity of Adding Node at particular position is O(n)
    }
    public void AddNodeAtStart(int data)
    {
        Node newNode = new Node(data,null);
        if (isEmpty())
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.next = head;
            head = newNode;
        }
        size = size + 1;
        //time complexity of adding element at start is O(1)
    }
    
    public void DeleteNodeStart()
    {
        
        if (size == 1)
        {
            Console.WriteLine("Deleted Node contais data: " + head.data);
            head = null;
            tail = null;
            size = size - 1;
        }
        else if (size == 0)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Console.WriteLine("Deleted Node contains data:" + head.data);
            head = head.next;
            size = size - 1;
        }
        
        //time complexity for removing element from start is O(1)
    }
    public void deleteNodeEnd()
    {
        if (size == 0)
        {
            Console.WriteLine("List is empty");
        }
        else if (size == 1)
        {
            Console.WriteLine("Deleted Node contains data: " + tail.data);
            head = null;
            tail = null;
            size = size - 1;
        }
        else
        {
            Node temp = head;
            int i = 1;
            while (i < size - 1)
            {
                temp = temp.next;
                i = i + 1;
            }
            Console.WriteLine("Deleted Node contains data: " + tail.data);
            tail = temp;
            tail.next = null;
            size=size - 1;
            //time complexity is O(n)
        }
    }

    public void deleteNodePosition(int position)
    {
        Node temp = head;
        int i = 1;
        while (i < size - 2)
        {
            temp = temp.next;
            i=i + 1;
        }
        Console.WriteLine("Node deleted contains data: " + temp.next.data);
        temp.next = temp.next.next;
        size = size - 1;
    }

    public int Search(int key)
    {
        Node temp = head;
        int i = 0;
        while(temp != null)
        {
            if (key == temp.data)
            {
                return i;
            }
            i = i + 1;
            temp = temp.next;
        }
        return -1;
    }
    public void display()
    {
        Node temp = head;
        while(temp != null)
        {
            Console.Write(temp.data+" ");
            temp = temp.next;
        }
        Console.WriteLine();
    }
    public void Reverse()
    {
        Node current = head;
        Node prev= null;
        Node forward = null;
        while (current != null)
        {
            forward = current.next;
            current.next = prev;
            prev = current;
            current = forward;
        }
        head = prev;
    }
    public static void Main(string[] args)
    {
        LinkedListt l = new LinkedListt();
        l.addNode(8);
        l.addNode(5);
        l.addNode(2);
        l.addNode(9);
        l.display();
        l.AddNodeAtStart(1);
        l.display();
        l.AddNodeAtPosition(4, 4);
        l.display();
       l.DeleteNodeStart();
        l.display();
        l.deleteNodeEnd();
        l.display();
        l.deleteNodePosition(3);
        l.display();
        int ans = l.Search(5);
        if (ans == -1)
        {
            Console.WriteLine("Node not found");
        }
        else
        {
            Console.WriteLine("Node found at index "+ ans);
        }
        l.Reverse();
        l.display();
    }
}