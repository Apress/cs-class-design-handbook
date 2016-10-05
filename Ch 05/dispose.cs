using System;
using System.IO;

public abstract class BasicShape : IDisposable
{
    protected int x;
    protected int y;
    private FileStream fStream;

    public virtual void GetCoords() {
       //possibly open a file handle here
       try
       {
       StreamReader sr = 
         new StreamReader((fStream = File.OpenRead("C:\\temp.txt")));
       int x = Convert.ToInt32(sr.ReadLine());
       int y = Convert.ToInt32(sr.ReadLine());
       }
       catch{}
    }

    public virtual void Dispose()
    {
         if(fStream!=null)
        	  {
             fStream.Close();
             fStream = null;
          }
  }
}

public class Square : BasicShape
{
   int a = 0;
   int b = 0;
  
   public override void GetCoords()
   {
      //do something associated with this class and then call the base class method which will change inherited fields 
      base.GetCoords();
   }

    public override void Dispose()
    {
      //clean up any resources associated with this object
      //clean up any resources associated with the base class object
      base.Dispose();
    }
}

