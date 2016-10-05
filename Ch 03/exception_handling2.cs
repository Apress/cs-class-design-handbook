// created on 12/3/2002 at 2:20 PM
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
      System.IO.StreamWriter 
       sw = new System.IO.StreamWriter("c:\\temp\\exceptions.txt");
    }
    catch (System.IO.DirectoryNotFoundException)
    {
      Console.WriteLine("The temp directory cannot be found");
    }
    catch (System.Exception)
    {
      Console.WriteLine("An error has occurred.");
    }
    finally
    {
      // Finally blocks are always executed regardless of whether an 
      //exception has been thrown.
    }
  }
}
