// created on 12/26/2002 at 5:30 PM
using System;
using System.IO;
using System.Collections;

namespace Inheritance
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class InvocationClass
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//
			// TODO: Add code to start application here
			//
			Example1 example1 = new Example1();
			Console.WriteLine("Class type instance is {0} and derives from {1}", example1.GetType().Name, example1.GetType().BaseType);
			Example2 example2 = new Example2();
			Console.WriteLine("Class type instance is {0} and derives from {1}", example2.GetType().Name, example2.GetType().BaseType);
			Example3 example3 = new Example3();
			Console.WriteLine("Class type instance is {0} and derives from {1}", example3.GetType().Name, example3.GetType().BaseType);
			Console.WriteLine(example1);
			Console.WriteLine(example2);
			Teacher st = new SupplyTeacher(54);
			Console.WriteLine(st.GetCountryCode());
			StaffTeacher staff = new StaffTeacher(54);
			Console.WriteLine(staff.GetCountryCode("UK"));
			string teacherString = String.Empty;
			InvocationClass.InvokeMemberOnTeacher(st, out teacherString);
			INonAdminPublicSectorWorker hw = new HospitalWorker();
			hw.Load("C:\\agenda.txt");
			InvocationClass.InvokeMemberOnINonAdminPublicSectorWorkerInterface(hw, "C:\\agenda.txt");
			HospitalWorker h = new HospitalWorker();
			Console.WriteLine(h.WastedTime());
			ILazyWorker ilw = (ILazyWorker)h;
			INonAdminPublicSectorWorker inaps2 = (INonAdminPublicSectorWorker)ilw;
			Console.WriteLine(inaps2.GetItem(DateTime.Now));
			Console.WriteLine(ilw.WastedTime());
		}

		public static int InvokeMemberOnTeacher(Teacher teach, out string WhichTeacher)
		{
			int pay = teach.CalculatePay();
			WhichTeacher = teach.GetType().Name; 
			return pay;
		}

		public static void InvokeMemberOnINonAdminPublicSectorWorkerInterface(INonAdminPublicSectorWorker inon, string fileName)
		{
			try
			{
				inon.Load(fileName);
			}
			catch
			{
			}
		}
	}

	public class Example1 
	{
		public override string ToString()
		{
			return "this class is example 1";
		}
	}

	public class Example2 : System.Object 
	{
		int x;
		int y;
		public Example2()
		{
			x = 0;
			y = 7;
		}

	}

	public struct Example3 
	{
			
	}

	



	

	interface INonAdminPublicSectorWorker 
	{
		void Load(string FileName);
		string GetItem(DateTime date);
	}

	interface ILazyWorker
	{
		int WastedTime();
		
	}

	interface ILazyWorker2
	{
		int WastedTime(int val);
	}

	public class HospitalWorker : INonAdminPublicSectorWorker, ILazyWorker, ILazyWorker2
	{
		private Hashtable ht = new Hashtable();
		private StreamReader reader;
		public virtual void Load(string FileName)
		{
			try
			{
				FileStream fStream = File.Open(FileName, FileMode.Open, FileAccess.Read);
				reader = new StreamReader(fStream);
				string fileContents = reader.ReadToEnd();
				foreach(string line in fileContents.Split(Environment.NewLine.ToCharArray()))
				{
					string[] agenda = line.Split(new Char[] { ',' });
					ht.Add(DateTime.Parse(agenda[0]), agenda[1]);
				}
			}
			catch{}
			finally
			{
				reader.Close();
			}

		}

		

		string INonAdminPublicSectorWorker.GetItem(DateTime dt)
		{
			return "Not implemented!";
		}

		public virtual string GetItem(DateTime dt)
		{
			return ht[dt].ToString();
		}

		public int WastedTime()
		{
			return -1;
		}

		int ILazyWorker.WastedTime()
		{
			return -2;
		}

		int ILazyWorker2.WastedTime(int i)
		{
			return -2;
		}
	}

	public class HWorker : HospitalWorker
	{
		public override string GetItem(DateTime dt)
		{
			return "";
		}
	}

	public abstract class Teacher
	{
		protected int salary;
		private int grade;
		protected int overtime;
		public int CalculateDaysWorked()
		{ return -1;}

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

		public virtual int CalculatePay()
		{
			if(salary==0)
			{
				throw new Exception("Unknown salary value");
			}
			return (salary / 12) + (overtime * (salary / (52 * 40)));
		}

		protected string subject;
		public virtual string GetTaughtSubjectName()
		{
			return subject;
		}
		public virtual int GetCountryCode()
		{
			return 54;
		}
	}

	public class SupplyTeacher : Teacher
	{
		public SupplyTeacher(int code) : base(1)
		{
			
		}

		private int monthDays;
		public sealed override int CalculatePay()
		{
			if(monthDays==0) monthDays = GetMonthDays(DateTime.Now.Month, DateTime.Now.Year); 
			return (int)(100 + (this.Grade * 10)) * monthDays;
		}

		private int GetMonthDays(int month, int year)
		{
			if(month==9||month==4||month==6||month==11)
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

		public int MonthDays
		{
			set
			{
				monthDays = value;
			}
		}


		public override int GetCountryCode()
		{
			return base.GetCountryCode();
		}
	}

	public class StaffTeacher : Teacher
	{
		public StaffTeacher(int code) : base(code)
		{
			
		}

		public override int CalculatePay()
		{
			return base.CalculatePay();
		}

		public int CalculatePay(int monthlySupplement)
		{
			if(monthlySupplement > 1000) throw new Exception("Supplement out of range exception");
			return base.CalculatePay() + monthlySupplement;
		}



		public override sealed int GetCountryCode()
		{
			return base.GetCountryCode();
		}

		public int GetCountryCode(string countryCodeArg)
		{
			return -1;
		}

		public new string GetTaughtSubjectName()
		{
			return this.subject;
		}
	}
	
}
