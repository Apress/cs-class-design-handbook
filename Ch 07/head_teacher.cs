using System;
public abstract class Teacher
{
   protected int salary;
   protected int grade;
   private bool isWorking = false;
   public abstract int CalculateDaysWorked ();
   public virtual void Work(bool isWorking)
   {
	//we could add some logging code here
        this.isWorking = isWorking;
   }
   protected bool IsWorking
   {
        get { return isWorking; }
   }

protected Teacher(int Grade)
{
   this.grade = Grade;
}

protected long Grade
{
   set
   {
     this.grade = (int)value;
   }
   get
   {
      return (long)grade;
   }
}
protected int overtime;
public virtual double CalculatePay()
{
  if(salary==0)
  {
   // throw new Exception("Unknown salary value");
  }
  return (salary / 12) + (overtime * (salary / (52 * 40)) * 1.5);
}
}
public class AbstractTeacherExample{

		public	static void Main(string[] args)
		{
		
		}
}
