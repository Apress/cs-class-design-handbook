using System;
class Employee 
{
   private string name;
   private string dept = "IT";
   private int salary;

   public string Name { get {return name;} }
   public string Dept { get {return dept;} }
   public int Salary { get {return salary;} }

public  Employee()
{
   Console.WriteLine("Default constructor called with no params");
}

public Employee(string name, string dept, int salary)
{
    this.name = name;
    this.dept = dept;
    this.salary = salary;
    Console.WriteLine("Constructor called with three params");
}

public Employee(string name, int salary)
{
   this.name = name;
   this.salary = salary;
   Console.WriteLine("Constructor called with two params");
}
}


public class testEmployee
{
  static void Main(string[] args)
  {
  
    Employee emp1 = new Employee();
    Console.WriteLine("Name:{0}\nDept:{1}\nSalary:{2}", emp1.Name,
                       emp1.Dept, emp1.Salary);
    Employee emp2 = new Employee("Jones", "Operations", 30000);
    Console.WriteLine("Name:{0}\nDept:{1}\nSalary:{2}", emp2.Name, 
                       emp2.Dept, emp2.Salary);
    Console.WriteLine("----------------------");
    Employee emp3 = new Employee("Smith", 35000);
    Console.WriteLine("Name:{0}\nDept:{1}\nSalary:{2}", emp3.Name, 
                       emp3.Dept, emp3.Salary);
  }
}
