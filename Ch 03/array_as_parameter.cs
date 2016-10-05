// created on 12/2/2002 at 5:41 PM

using System;
class ArrayParams
{
 private static int AddRange(int[] range)
{
  
  int total = 0;

 for(int i = 0;  range.Length; i++)
  {
    total = total + range[i];
  }


  return total;
}
}
public class arrays_example
{
  public static void Main()
  {
    Console.WriteLine("Average ");
 
  }
}


