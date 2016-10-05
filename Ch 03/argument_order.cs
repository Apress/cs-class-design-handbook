using System;
public class method_overload{

public int Add(int number_one, double number_two)
{
  return (int)(number_one + number_two);
}

public int Add(double number_two, int number_one)
{
  return (int)(number_two - number_one);
}
 
 public static void Main(string[] args)
    {
      
      method_overload overload_meth = new method_overload();

      Console.WriteLine("Add (int, double)"+ overload_meth.Add(4,3.2));
      Console.WriteLine("Add (int, double)"+ overload_meth.Add(4.2,3)); 
    }
  }
