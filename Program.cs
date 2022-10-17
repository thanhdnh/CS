public class Program
{
  static void CreateArray(out Array arr, int length, int lowerbound){
    Random r = new Random();
    arr = Array.CreateInstance(typeof(float), new int[1]{length}, 
      new int[1]{lowerbound});
    for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
      arr.SetValue(r.NextSingle()*10, i);
  }
  static void CreateArray2(Array arr){
    Random r = new Random();
    for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
      arr.SetValue(r.NextSingle()*10, i);
  }
  static float SumArray(Array arr){
    float sum = 0;
    foreach(float v in arr)
      sum += v;
    return sum;
  }
  static void Create2DArray(out Array arr, int[] length, int[] lowerbound){
    Random r = new Random();
    arr = Array.CreateInstance(typeof(int), length, lowerbound);
    for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
      for(int j=arr.GetLowerBound(1); i<=arr.GetUpperBound(1); i++)
        arr.SetValue(r.NextSingle()*10, i, j);
  }
  static void Print2DArray(Array arr){
    for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++){
      for(int j=arr.GetLowerBound(1); i<=arr.GetUpperBound(1); i++)
        System.Console.Write("{0, 5}", arr.GetValue(i, j));
      System.Console.WriteLine();
    }
  }
  static void Main(){
    Console.Clear();
    Array arr2d;  int[] len = {2, 3}; int[] lb = {0, 0};
    Create2DArray(out arr2d, len, lb);
    Print2DArray(arr2d);
    /*Array arr;
    CreateArray(out arr, 5, 0);
    System.Console.WriteLine("Tong: " + SumArray(arr));
    */

    Console.ReadLine();
  }
}