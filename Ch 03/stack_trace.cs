// created on 12/2/2002 at 8:53 PM
using System;
using System.Diagnostics;

namespace stack_trace
{
  class Foo
  {
    static void Main(string[] args)
    {
      Bar.BarMethod(42);
      Console.ReadLine();
    }
  }

  class Bar
  {
    public static void BarMethod(int x)
    {
      StackTrace st = new StackTrace();

      for(int i=0; i < st.FrameCount; i++)
      {
        StackFrame sf = new StackFrame();
	sf = st.GetFrame(i);
	Console.WriteLine(sf.GetMethod());
      }
    }
  }
}
