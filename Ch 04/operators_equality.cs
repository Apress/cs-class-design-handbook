// created on 12/24/2002 at 12:49 PM
using System;

class Employee
{
  private string name;
  private int salary;

  public string Name
  {
    get { return name; }
    set { name = value; }
  }

  public int Salary
  {
    get { return salary; }
    set { salary = value; }
  }
  
  public static bool operator==(Employee left_employee, 
                                Employee right_employee)
  {
    if (left_employee.Name == right_employee.Name)
      return true;
    else
      return false;
  }

  public static bool operator!=(Employee left_employee, Employee right_employee)
  {
    if (left_employee.Name != right_employee.Name)
      return true;
    else
      return false;
  }

  public override bool Equals(object type)
  {
    if (!(type is Employee))
      return false;
    else
      return this ==(Employee)type;
  }

  public override int GetHashCode()
  {
    return this.Name.GetHashCode() + this.Salary.GetHashCode();
  }
}

  class CalculateBonus
  {
    static void Main()
    {
      Employee employee_one = new Employee();
      Employee employee_two = new Employee();
      Employee employee_three = new Employee();

      employee_one.Name = "James";
      employee_two.Name = "Steve";

      employee_three = employee_one;

      if (employee_one == employee_two)
        Console.WriteLine("Employee One is the same as Employee Two");
      else
        Console.WriteLine("Employee One is NOT the same as Employee Two");

      if (employee_one == employee_three)
        Console.WriteLine("Employee One is the same as Employee Three");
      else
        Console.WriteLine("Employee One is NOT the same as Employee Three");

      employee_three.Name = "Steve";

      if (employee_two == employee_three)
        Console.WriteLine("Employee Two is the same as Employee Three");
      else
        Console.WriteLine("Employee Two is NOT the same as Employee Three");
    }
  }
