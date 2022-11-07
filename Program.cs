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
    public Node FindMax(){
      Node current = header;
      Node max = new Node();
      max.element = int.MinValue.ToString();
      while(current.link!=null){
        if(current!=header)
          if(int.Parse(current.element.ToString())>int.Parse(max.element.ToString())){
            max.element = current.element;
            max.link = null;
          }
        current = current.link;
      }
      return max;
    }
    public Node FindMax2(){
      Node current = header;
      current = current.link;
      Node max = new Node();
      max.element = current.element;
      max.link = null;
      while(current.link!=null){
        if(int.Parse(current.element.ToString())>int.Parse(max.element.ToString())){
          max.element = current.element;
          max.link = null;
        }
        current = current.link;
      }
      return max;
    }
  }

  static void Main()
  {
    Console.Clear();

    LinkedList list = new LinkedList();
    list.Insert("1", "Header");
    list.Insert("15", "1");
    list.Insert("12", "15");
    list.Insert("19", "12");
    list.Insert("11", "19");
    list.Print();
    System.Console.WriteLine("Max node: " + list.FindMax2().element.ToString());

    Console.ReadLine();
  }
}