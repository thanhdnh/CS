using System;
using System.Collections.Generic;
using System.Collections;
public class Program
{
  static void Main()
  {
    Console.Clear();

    Account acc1 = new Account("abc", "123456789", "Hello!");
    string email1 = "abc@xyz.com";
    Account acc2 = new Account("def", "234567891", "Hi!");
    string email2 = "def@xyz.com";
    Account acc3 = new Account("feg", "345678912", "Hey!");
    string email3 = "feg@xyz.com";
    DictAccount dict = new DictAccount();
    dict.Add(email1, acc1);
    dict.Add(email2, acc2);
    dict.Add(email3, acc3);

    //System.Console.WriteLine(dict.Item("def@xyz.com"));
    IDictionaryEnumerator enumerate = dict.GetEnumerator();
    while(enumerate.MoveNext())
      System.Console.WriteLine("{0}=>{1}", enumerate.Key, enumerate.Value);
    
    Console.ReadLine();
  }
}