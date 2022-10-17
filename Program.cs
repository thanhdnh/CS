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
  static void Main()
  {
    Console.Clear();

    Array arr;
    CreateArray(out arr, 5, 0);
    System.Console.WriteLine("Tong: " + SumArray(arr));

    Console.ReadLine();
  }
}