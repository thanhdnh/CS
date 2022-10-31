using System;
public class Program
{
  static int SeqSearch(int[] arr, int value)
  {
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] == value)
        return i;
    return -1;
  }
  static int SeqLastSearch(int[] arr, int value)
  {
    int t = -1;
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] == value)
        t = i;
    return t;
  }
  static List<int> SeqMultiSearch(int[] arr, int value)
  {
    List<int> result = new List<int>();
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] == value)
        result.Add(i);
    return result;
  }
  static int RecuSearch(int[] arr, int from, int value)
  {
    if (arr.Length == 0 || from >= arr.Length)
      return -1;
    else
    {
      if (arr[from] == value)
        return from;
      else
        return RecuSearch(arr, from + 1, value);
    }
  }
  static int SenSearch(int[] A, int value)
  {
    int x = A[A.Length - 1];
    A[A.Length - 1] = value;
    int i = 0;
    while (A[i] != value)
      i++;
    A[A.Length - 1] = x;
    if (A[A.Length - 1] == value || i < A.Length - 1)
      return i;
    return -1;
  }
  static void Main()
  {
    Console.Clear();

    int[] arr = new int[6] { 3, 6, 1, 9, 4, 6 };
    System.Console.WriteLine("Vi tri PT {0} la {1}", 9, SenSearch(arr, 9));
    //System.Console.WriteLine("Vi tri PT {0} la {1}", 6, RecuSearch(arr, 0, 6));
    /*List<int> result = SeqMultiSearch(arr, 6);
    if (result.Count > 0)
    {
      Console.Write("Vi tri cua {0} la: ", 6);
      foreach (int v in result)
        Console.Write(v + " ");
      Console.WriteLine();
    }
    else
      System.Console.WriteLine("Không tồn tại phần tử {0}", 6);
    */
    /*Console.WriteLine("Vi tri cua {0} la: {1}", 1, SeqSearch(arr, 1));
    Console.WriteLine("Vi tri cua {0} la: {1}", 6, SeqSearch(arr, 6));
    Console.WriteLine("Vi tri cua {0} la: {1}", 11, SeqSearch(arr, 11));*/
    /*Console.WriteLine("Vi tri cua {0} la: {1}", 1, SeqLastSearch(arr, 1));
    Console.WriteLine("Vi tri cua {0} la: {1}", 6, SeqLastSearch(arr, 6));
    Console.WriteLine("Vi tri cua {0} la: {1}", 11, SeqLastSearch(arr, 11));*/


    Console.ReadLine();
  }
}