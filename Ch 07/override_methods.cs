using System;

public class Example1 
{
   public override string ToString()
   {
       return "this class is example 1";
   }
}


public class mainExample1
{
  static void Main(string[] args)
  {
    Example1 example1 = new Example1();
    Console.WriteLine(example1);
  }
}
