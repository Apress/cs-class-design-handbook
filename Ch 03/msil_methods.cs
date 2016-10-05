// created on 12/3/2002 at 2:56 PM
using System;

namespace msil_methods
{
  class MSILMethods
  {
    static void Main(string[] args)
    {
      int result = 0;
      int total;
      int net = 0;

      MethodExamples examples = new MethodExamples();
			
      result = examples.ByValueMethod(7);
      result = examples.ByRefMethod(result);
      examples.OutputMethod(out total, result);
      result = result + examples.OverloadMethod(total);
      total = examples.OverloadMethod(result, total);
      net = examples.ParamsMethod(result, total);
    }
  }

  class MethodExamples
  {
    public int ByValueMethod(int a)
    {
      return a++;
    }

		public int ByRefMethod(int b)
		{
			b = b * 2;
			return b;
		}

		public void OutputMethod(out int c, int d)
		{
			c = d / 4;
		}

		public int OverloadMethod(int e)
		{
			return e + 2;
		}

		public int OverloadMethod(int e, int f)
		{
			return e + f;
		}

		public int ParamsMethod(params int[] g)
		{
			int total = 0;

			foreach(int num in g)
			{
				total = total + num;
			}

			return total + 1;
		}
	}
}
