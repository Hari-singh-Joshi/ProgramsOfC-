using System;
public class Program{
  //enums start here
   enum Days{
    sat=1,sun,mon,tue,wed,thu,fir
  };
  public static void Main(){
    int x=(int)Days.sun;
    int y=(int)Days.mon;
    Console.WriteLine("Sun={0}",x);
    Console.WriteLine("Mon={0}",y);
   
   
    Console.ReadKey();

  
  }  
    }
