public class Program
{
  static void RandomizeArray(int[] arr){
    Random r = new Random();
    for(int i=0; i<arr.Length; i++)
      arr[i] = r.Next(1, 9999);
  }
  static void SortArray(int[] arr){
    for(int i=0; i<arr.Length-1; i++)
      for(int j=i+1; j<arr.Length; j++){
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
      }
  }
  static void Main()
  {
    Console.Clear();
    Timing timer = new Timing();
    int[] arr = new int[100000];
    timer.startTime();
    RandomizeArray(arr);
    timer.StopTime();
    System.Console.WriteLine("RandomizeArray takes {0} seconds", timer.Result().TotalSeconds);
    
    timer.startTime();
    SortArray(arr);
    timer.StopTime();
    System.Console.WriteLine("SortArray takes {0} seconds", timer.Result().TotalSeconds);
    Console.ReadLine();
  }
}