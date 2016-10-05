// created on 12/2/2002 at 3:10 PM
using System;

namespace valuetype_by_reference
{
  public struct EmployeeStruct
  {
    double salary;

    public double Salary
    {
      get
        {
	  return salary;
	}
      set
	{
	  salary = value;
	}
    }
  }

  public class CalculationClass
  {
    public static double CalculateTax(ref EmployeeStruct employee)
    {
      employee.Salary = employee.Salary * 0.75;
      return employee.Salary;
    }
  }

  class Class1
  {
    static void Main(string[] args)
    {
      double netSalary;

      EmployeeStruct employee_value = new EmployeeStruct();

      employee_value.Salary = 40000;
						
      Console.WriteLine("Gross salary before tax - {0}", employee_value.Salary);

      netSalary = CalculationClass.CalculateTax(ref employee_value);

      Console.WriteLine("Gross salary before tax - {0}", employee_value.Salary);
      Console.WriteLine("Net salary after tax - {0}", netSalary);
			
      Console.ReadLine();
    }
  }
}
