//Indexers allow instances of a class or struct to be indexed just like arrays.
//indexers enable objects to be indexed in a similar manner to arrays.
using System;
class SampleCollection<T>{
  private T[] arr=new T[100];
  public T this[int i]{
    get{return arr[i];}
    set{arr[i]=value;}
  }
}
class Program{
  static void Main(){
    var strc=new SampleCollection<string>();
    strc[0]="Hello World";
    strc[1]="Namste Duniya";
    Console.WriteLine(strc[1]);
    Console.ReadKey();
  }
}