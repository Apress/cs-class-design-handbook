using System;

public class Employee
{
  int m_salary;

  public int Salary
  {
    get
    {
      return m_salary;
    }
    set
    {
      m_salary = value;
    }
  }
}

public class Taxation
{
  public static void Calculate(Employee employee)
  {
    employee.Salary = employee.Salary - ((employee.Salary/100)*22);
  }
}

class Calculate
{
  static void Main(string[] args)
  {
    Employee employee = new Employee();

    employee.Salary = 40000;
    Console.WriteLine("Gross salary before tax - {0}", employee.Salary);

    Taxation.Calculate(employee);

    Console.WriteLine("Net salary after tax    - {0}", employee.Salary);
  }
}
