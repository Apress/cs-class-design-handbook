using System;

public class Worker
{
	public class NestedWorker
	{
		Worker wk;
		public NestedWorker()
		{
			wk = new Worker();
		}
	}

	private Worker()
	{
		Console.WriteLine("private constructor called!");
	}

	static void Main(string[] args)
	{
		NestedWorker nw = new NestedWorker();
	}
}
