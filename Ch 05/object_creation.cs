using System;
class Employee 
{
   private string name;
   private string dept = "IT";
   private int salary;

   public string Name { get {return name;} }
   public string Dept { get {return dept;} }
   public int Salary { get {return salary;} }
}

 public class emp_class{
  [STAThread]
   static void Main(string[] args){
       Employee emp = new Employee();
       Console.WriteLine("Name:{0}\nDept:{1}\nSalary:{2}", 
                               emp.Name, emp.Dept, emp.Salary);
      }
 }
