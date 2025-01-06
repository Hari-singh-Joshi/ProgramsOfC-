//Static Compile Time Polymorphism: difference in parameters(no. or types)
using System;
public class TestData{
  public int Add(int a,int b,int c){
    return a+b+c;
  }
  public int Add(int a,int b){
    return a+b;
  }
}
class Program{
  public static void Main(string[] args){
    TestData obj1=new TestData();
    Console.WriteLine(obj1.Add(2,3,7));
    Console.WriteLine(obj1.Add(2,3));
  }
}