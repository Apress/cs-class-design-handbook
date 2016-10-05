using System;



public class Example1 
{

}

public class Example2 : System.Object 
{

}

public struct Example3
{

}

public class mainMethod
{
	static void Main()
	{
		Example1 example1 = new Example1();
		Console.WriteLine("Class type instance is {0} and derives from {1}", example1.GetType().Name, example1.GetType().BaseType);

		Example2 example2 = new Example2();
		Console.WriteLine("Class type instance is {0} and derives from {1}", example2.GetType().Name, example2.GetType().BaseType);

		Example3 example3 = new Example3();
		Console.WriteLine("Class type instance is {0} and derives from {1}", example3.GetType().Name, example3.GetType().BaseType);
	}
}
