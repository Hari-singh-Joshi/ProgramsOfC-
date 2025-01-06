//Encapsulation
using System;
public class Department{
  private string department;
  public string GetDepartment(){
    return department;
  }
  public void SetDepartment(string a){
    department=a;
  }
  }
public class Program{
  
public static void Main(string[] args){
Department d=new Department();
d.SetDepartment("computer science");
Console.WriteLine("The Department is"+d.GetDepartment());
Console.ReadKey();

  }
}