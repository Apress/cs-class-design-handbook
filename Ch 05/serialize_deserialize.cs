using System;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization;
/*you won't be using the Binary Formatter but if you need to use it you must define the following using statement*/
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

[Serializable()]
public class Teacher : ICloneable
{
   private int grade;
   private int salary;
   [NonSerialized]
   private string dept = String.Empty;

   public Teacher() {}

   public Teacher(int grade, int salary, string dept) 
   {
   	this.grade = grade;
   	this.salary = salary;
   	this.dept = dept;
   }

  public Teacher(Teacher teach)
 {
   PropertyInfo[] pInfoArray = teach.GetType().GetProperties();
   foreach(PropertyInfo pInfo in pInfoArray)
   {
      Type ty = pInfo.PropertyType;
      object myvalue = 
      teach.GetType().InvokeMember(pInfo.Name, 
                                   BindingFlags.GetProperty, null, 
                                   teach, null);
      teach.GetType().InvokeMember(pInfo.Name,
                                   BindingFlags.SetProperty, null, 
                                   this, new object[]{myvalue});
   }
  }

   	public int Grade { get { return grade; } set { grade = value; }}
	public int Salary { get { return salary; } set { salary = value; }}
	public string Dept { get { return dept; } set { dept = value; }}

	public object Clone()
	{
    	return new Teacher(grade, salary, dept);
	}
   	
}

public class mainTeacher
{
	static void Main()
	{
		Teacher teach1 = new Teacher(3, 23000, "IT");
		Teacher teach2 = new Teacher(teach1);
		Teacher teach3 = (Teacher)teach2.Clone();
		Console.WriteLine("Details of the First teacher are \nDept:{0} \nGrade:{1} \nSalary:{2}\n", teach1.Dept,teach1.Grade,teach1.Salary);
		Console.WriteLine("Details of the Second Teacher are \nDept:{0} \nGrade:{1} \nSalary:{2}\n", teach2.Dept, teach2.Grade, teach2.Salary);
		
		FileStream fTeacher = File.Open("C:\\teacher.xml", 
                                 FileMode.OpenOrCreate, 
                                 FileAccess.ReadWrite);
SoapFormatter sfTeacher = new SoapFormatter();
sfTeacher.Serialize(fTeacher, teach3);
		
		fTeacher.Position = 0;
		
		Teacher teach4 = (Teacher)sfTeacher.Deserialize(fTeacher); 
Console.WriteLine("Details:{0}, {1}, {2}", teach4.Grade, teach4.Dept, teach4.Salary);
		fTeacher.Close();
	}
}
