using System;
namespace Switch_Case{
  class Program{
    public static void Main(string[] args){
      int Day;
      Console.WriteLine("Enter Your Choice (1-7 for days of the week):");
      
      // Validate input
      if (int.TryParse(Console.ReadLine(), out Day)) {
        switch (Day){
          case 1:
            Console.WriteLine("Sunday");
            break;
          case 2:
            Console.WriteLine("Monday");
            break;
          case 3:
            Console.WriteLine("Tuesday");
            break;
          case 4:
            Console.WriteLine("Wednesday");
            break;
          case 5:
            Console.WriteLine("Thursday");
            break;
          case 6:
            Console.WriteLine("Friday");
            break;
          case 7:
            Console.WriteLine("Saturday");
            break;
          default: 
            Console.WriteLine("Enter a number between 1 to 7");
            break;
        }
      } else {
        Console.WriteLine("Invalid input! Please enter a valid number.");
      }
      
      Console.ReadLine();
    }
  }
}
