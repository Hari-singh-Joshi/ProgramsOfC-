//Dynamic or Runtime Polymorphism(late binding)-implementation of methods are different(Method Overriding)
using System;
public class Drawing{
  public virtual double Area(){
    return 0;
  }
}
public class Circle:Drawing{
  public double Radius{ get;set; }

    public Circle(){
      Radius=5;
  }
    public override double Area()
    {
        return (3.14)*Math.Pow(Radius,2);
    }
}
public class Program{
  public static void Main(string[] args){
    Drawing circle=new Circle();
    Console.WriteLine("Area:"+circle.Area());
    Console.ReadKey();
  }
}