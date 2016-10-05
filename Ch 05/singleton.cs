using System;
using System.Runtime.CompilerServices;

public class HeadTeacher
{
	private static HeadTeacher headTeacher = null;
	private int grade;
	private string name;
	private HeadTeacher() {}


	public static HeadTeacher getInstance()
	{
		if(headTeacher == null)
		{
			Console.WriteLine("HeadTeacher instance created!");
			headTeacher = new HeadTeacher();
			return headTeacher;
		}
		else
		{
			Console.WriteLine("HeadTeacher instance already exists!");
			return headTeacher;
		}
	}

public int Grade
  {
    get
    {
      return grade;
    }
    set
    {
      grade = value;
    }
  }

  public string Name 
  {
    get
    {
      return name;
    }
    set
    {
      name = value;
    }
  }
}

public class mainHeadTeacher
{
	static void Main()
	{
		HeadTeacher ht1 = HeadTeacher.getInstance();
		HeadTeacher ht2 = HeadTeacher.getInstance();
		ht1.Grade = 10;
		Console.WriteLine("ht1 Grade:{0}", ht1.Grade);
		Console.WriteLine("ht2 Grade:{0}", ht2.Grade);
	}
}
