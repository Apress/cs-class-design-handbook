using System;

public class Teacher
{
   	 public Teacher()
	{
       Console.WriteLine("Base class instance created");
	}

	static Teacher()
	{
      Console.WriteLine("Class loaded");
	}

 }

  	public class SupplyTeacher : Teacher
	{
		public SupplyTeacher ()
		{
		   Console.WriteLine("Derived class instance created");
     	}

		static void Main(string[] args)
		{
   		  SupplyTeacher teach = new SupplyTeacher();
          SupplyTeacher teach1 = new SupplyTeacher();
		}

	}



