// created on 12/24/2002 at 11:59 AM
// created on 12/24/2002 at 11:52 AM
using System;

class Bonus
{
  private int bonus;

  public int Amount
  {
    get { return bonus;  }
    set { bonus = value; }
  }
}

class Employee
{
  private string name;
  private int salary;

  public string Name
  {
    get { return name;  }
    set { name = value; }
  }

  public int Salary
  {
    get { return salary;  }
    set { salary = value; }
  }
 
  public static Employee operator+(Employee employee, Bonus bonus)
  {
    employee.Salary = employee.Salary + bonus.Amount;
    return employee;
  }

}

class CalculateBonus
{
 static void Main()
  {
    Employee employee = new Employee();
    Bonus bonus = new Bonus();

    employee.Name = "James";
    employee.Salary = 8000;

    bonus.Amount = 1000;

    Console.WriteLine(employee.Name + " - " + employee.Salary);

    employee = employee + bonus;

    Console.WriteLine(employee.Name + " - " + employee.Salary);
  }

}
