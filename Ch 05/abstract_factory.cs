// created on 2/21/2003 at 11:19 AM
public abstract class MedicalStaff
{
	protected int salary;
	protected int grade;
	protected string hospital;
	
	public int Pay
	{
		get { return this.salary; }
		set { this.salary = value ; }
	}
	
	public int Grade
	{
		get { return this.grade; }
		set { this.grade = value; }
	}
	
	public string Hospital
	{
		get { return this.hospital; }
		set { this.hospital = value; }
	}
}

public abstract class Doctor : MedicalStaff{}
public abstract class Nurse : MedicalStaff{}

public class StudentNurse: Nurse {}
public class QualifiedNurse : Nurse{}
public class QualifiedDoctor : Doctor{}
public class StudentDoctor :  Doctor{} 


public abstract class HospitalWorkerFactory
{
	public abstract Nurse GetNurse();
	public abstract Doctor GetDoctor();
	
}

public class StudentFactory : HospitalWorkerFactory
{
	public override Nurse GetNurse()
	{
		return new StudentNurse();
	}
	public override Doctor GetDoctor()
	{
		return new StudentDoctor();
	}
}

public class QualifiedFactory : HospitalWorkerFactory
{
	public override Nurse GetNurse()
	{
		return new QualifiedNurse();
	}
	public override Doctor GetDoctor()
	{
		return new QualifiedDoctor();
	}
}
