using System;
using System.IO;

public class Lazy
{
   private int id;
   private string name;
   public Lazy(int number){
     id = number;
   }

   public int ID{
     get{
        return id;
     }
   }

   public string Name{
      get{
         if(name==null)
         {
             StreamReader sr = new
                 StreamReader("C:\\name"+id.ToString("0000")+".txt");
             name = sr.ReadToEnd();
         }
         return name;
      }
  }
}
