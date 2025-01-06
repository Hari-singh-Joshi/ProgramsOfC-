//Interface(neither have body nor instantiated)
using System;
interface Wish{
  void sayhello();
  void saybye();
}
class collegestud : Wish{
  public void sayhello(){
    Console.WriteLine("Hello sir/mam");
  }
  public void saybye(){
    Console.WriteLine("goodbye sir/mam");
  }

}
class Program{
  public static void Main(string[] args){
    collegestud c1=new collegestud();
    c1.sayhello();
    c1.saybye();
    Console.ReadKey();
  }
}