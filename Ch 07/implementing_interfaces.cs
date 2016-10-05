using System;
using System.IO;
using System.Collections;

namespace Inheritance
{
	class InvocationClass
	{
	    [STAThread]
		static void Main(string[] args)
		{
			
			INonAdminPublicSectorWorker hw = new HospitalWorker();
			hw.Load("C:\\agenda.txt");
			InvocationClass.INonAdminPublicSectorWorker(hw, "C:\\agenda.txt");
			HospitalWorker h = new HospitalWorker();
			Console.WriteLine(h.WastedTime());
			ILazyWorker ilw = (ILazyWorker)h;
			INonAdminPublicSectorWorker inaps2 = (INonAdminPublicSectorWorker)ilw;
		    Console.WriteLine(ilw.WastedTime());
			Console.WriteLine(inaps2.GetItem(DateTime.Now));
		}

	

		public static void INonAdminPublicSectorWorker(INonAdminPublicSectorWorker inon, string fileName)
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
}
