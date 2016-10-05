// created on 12/3/2002 at 2:16 PM
using System;
class exception_handling
{
  static void Main(string[] args)
  {
    Console.WriteLine("Calling Save Data");
    SaveData();
    Console.WriteLine("Save Data finished.");
    Console.ReadLine();
  }

  private static void SaveData()
  {
    try
    {
      System.IO.StreamWriter sw = new System.IO.StreamWriter("c:\\temp\\exceptions.txt");
    }
    catch (System.Exception)
    {
      Console.WriteLine("An error has occurred.");
    }
    finally
    {
      Console.WriteLine("Finally block.");
    }
  }
}
