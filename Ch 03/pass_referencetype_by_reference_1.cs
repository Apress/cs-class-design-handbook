// created on 12/2/2002 at 4:07 PM
// created on 12/2/2002 at 4:03 PM
using System;

namespace referencetype_by_value
{
  public class EmployeeClass
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
    public static double CalculateTax(ref EmployeeClass employee)
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

      EmployeeClass employee_reference = new EmployeeClass ();

      employee_reference.Salary = 40000;
						
      Console.WriteLine("Gross salary before tax - {0}",
                                      employee_reference.Salary);

      netSalary = CalculationClass.CalculateTax(ref 
                                      employee_reference);

      Console.WriteLine("Gross salary before tax - {0}",
                                      employee_reference.Salary);
      Console.WriteLine("Net salary after tax - {0}", netSalary);
			
      Console.ReadLine();
    }
  }
}
