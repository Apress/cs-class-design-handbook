using System;
using System.Diagnostics;

public class Manager 
{
    private int grade; 
    private string name;

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

    public Manager() : this("N/A", 0) 
    {
      EventLog.WriteEntry("Manager class", "Manager created without name!");
    }
    

    public Manager(string name) : this(name, 0) {}

    public Manager(string name, int grade)
    {
      Name = name;
      Grade = grade;
    }
}

public class mainMangaer
{
	[STAThread]
		static void Main(string[] args)
		{
			Manager mgr_Jones = new Manager("Jones");
			Manager mgr_Blank = new Manager();
			Manager mgr_Name_Grade = new Manager("Jones", 4);
		
		}
}
