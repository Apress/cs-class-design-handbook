using System;

public abstract class Teacher
{
   protected int salary;
   protected int grade;
   private bool isWorking = false;
   protected int overtime;
   protected int employeeNumber;
   
   public virtual void Work(bool isWorking)
   {
       //we could add some logging code here
        this.isWorking = isWorking;
   }
   
  protected Teacher(int number){
   	this.employeeNumber= number;
   }
                     
   
   protected bool IsWorking
   {
        get { return isWorking; }
   }
  
  public virtual double CalculatePay()
  {
    if(salary==0)
    {
     // throw new Exception("Unknown salary value");
    }
    return (salary / 12) + (overtime * (salary / (52 * 40)) * 1.5);
  }
}

public class SupplyTeacher : Teacher
{
  public  SupplyTeacher(int number) : base(number)
	{
		Console.WriteLine(base.salary);
		salary =  (int)CalculatePay() * 12;
	}

  private int monthDays;
  public override sealed double CalculatePay()
  {
    if(monthDays==0) monthDays = GetMonthDays(DateTime.Now.Month, DateTime.Now.Year);
    return (100 + (this.grade * 10)) * monthDays;
  }

  protected int MonthDays
  {
    set
    {
      monthDays = value;
    }
  }

  private int GetMonthDays(int month, int year)
  {      if(month==9||month==4||month==6||month==11)
    {
      return 30;
    }
    if(month==2&&(year%4==0))
    {
      return 29;
    }
    else if(month==2&&(year%4!=0))
    {
      return 28;
    }
    return 31;
  }
}
public class SealedTeacherExample
{
    public static void Main(string[] args)
    {
    }
}

