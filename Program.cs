using System;
public class Program
{
  public class Node
  {
    public object element;
    public Node link;
    public Node()
    {
      element = null;
      link = null;
    }
    public Node(object element)
    {
      this.element = element;
      link = null;
    }
  }
  public class LinkedList
  {
    public Node header;
    public LinkedList()
    {
      header = new Node("Header");
    }
    private Node Find(object element)
    {
      Node current = new Node();
      current = header;
      while (current.element != element)
        current = current.link;
      return current;
    }
    public void Insert(object newelement, object afterelement)
    {
      Node current = new Node();
      Node newnode = new Node(newelement);
      current = Find(afterelement);
      newnode.link = current.link;
      current.link = newnode;
    }
    public Node FindPrev(object element)
    {
      Node current = header;
      while (current.link != null && current.link.element != element)
        current = current.link;
      return current;
    }
    public void Remove(object element)
    {
      Node current = FindPrev(element);
      if (current.link != null)
        current.link = current.link.link;
    }
    public void Print()
    {
      Node current = new Node();
      current = header;
      while (current.link != null)
      {
        Console.WriteLine(current.link.element);
        current = current.link;
      }
    }
    public Node FindMax()
    {
      Node current = header;
      Node max = new Node();
      max.element = int.MinValue.ToString();
      while (current.link != null)
      {
        if (current != header)
          if (int.Parse(current.element.ToString()) > int.Parse(max.element.ToString()))
          {
            max.element = current.element;
            max.link = null;
          }
        current = current.link;
      }
      return max;
    }
    public Node FindMax2()
    {
      Node current = header;
      current = current.link;
      Node max = new Node();
      max.element = current.element;
      max.link = null;
      while (current.link != null)
      {
        if (int.Parse(current.element.ToString()) > int.Parse(max.element.ToString()))
        {
          max.element = current.element;
          max.link = null;
        }
        current = current.link;
      }
      return max;
    }
  }

  public class Node2
  {
    public object element;
    public Node2 flink, blink;
    public Node2()
    {
      element = null;
      flink = blink = null;
    }
    public Node2(object element)
    {
      this.element = element;
      flink = blink = null;
    }
  }

  public class DoubleLinkedList
  {
    public Node2 header;
    public DoubleLinkedList()
    {
      header = new Node2("Header");
    }
    private Node2 Find(object element)
    {
      Node2 current = new Node2();
      current = header;
      while (current.element != element)
      {
        current = current.flink;
      }
      return current;
    }
    public void Insert(object newelement, object afterelement)
    {
      Node2 current = new Node2();
      Node2 newnode = new Node2(newelement);
      current = Find(afterelement);
      newnode.flink = current.flink;
      newnode.blink = current;
      current.flink = newnode;
    }
    public void Remove(object element)
    {
      Node2 current = Find(element);
      if (current.flink != null)
      {
        current.blink.flink = current.flink;
        current.flink.blink = current.blink;
        current.flink = null;
        current.blink = null;
      }
    }
    private Node2 FindLast()
    {
      Node2 current = new Node2();
      current = header;
      while (!(current.flink == null))
        current = current.flink;
      return current;
    }
    public void Print()
    {
      Node2 current = new Node2();
      current = FindLast();
      while (!(current.blink == null))
      {
        Console.WriteLine(current.element);
        current = current.blink;
      }
    }
    public Node2 FindMax()
    {
      Node2 current = FindLast();
      Node2 max = new Node2();
      max.element = current.element;
      while (!(current.blink.blink == null))
      {
        if(int.Parse(max.element.ToString())<int.Parse(current.element.ToString())){
          max.element = current.element;
          max.blink = max.flink = null;
        }
        current = current.blink;
      }
      return max;
    }
  }
  static void Main()
  {
    Console.Clear();

    /*LinkedList list = new LinkedList();
    list.Insert("1", "Header");
    list.Insert("15", "1");
    list.Insert("12", "15");
    list.Insert("19", "12");
    list.Insert("11", "19");
    list.Print();
    System.Console.WriteLine("Max node: " + list.FindMax2().element.ToString());
    */
    DoubleLinkedList dlist = new DoubleLinkedList();
    dlist.Insert("22", "Header");
    dlist.Insert("45", "22");
    dlist.Insert("11", "45");
    dlist.Insert("40", "11");
    dlist.Insert("9", "40");
    Console.WriteLine("Max of DoubleLinkedList: "+dlist.FindMax().element.ToString());

    Console.ReadLine();
  }
}