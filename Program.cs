public class Program
{
  static ulong TinhTong1(int n){//dùng if ktra chẵn
    ulong sum = 0;
    for(int i=0; i<=n; i++)
      if(i%2==0)
        sum+=(ulong)i;
    return sum;
  }
  static ulong TinhTong2(int n){//dùng continue
    ulong sum = 0;
    for(int i=0; i<=n; i++){
      if(i%2!=0)
        continue;
      sum+=(ulong)i;
    }
    return sum;
  }
  static ulong TinhTong3(int n){//dùng tăng 2 đơn vị
    ulong sum = 0;
    for(int i=0; i<=n; i+=2)
      sum+=(ulong)i;
    return sum;
  }
  static void Main()
  {
    Console.Clear();
    int n = 1000000;
    Timing timer = new Timing();
    timer.startTime(); TinhTong1(n); timer.StopTime();
    System.Console.WriteLine("Tong 1: " + timer.Result().TotalMilliseconds);

    timer.startTime(); TinhTong2(n); timer.StopTime();
    System.Console.WriteLine("Tong 2: " + timer.Result().TotalMilliseconds);

    timer.startTime(); TinhTong3(n); timer.StopTime();
    System.Console.WriteLine("Tong 3: " + timer.Result().TotalMilliseconds);
    Console.ReadLine();
  }
}