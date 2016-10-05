using System;

class preString
{
	//while compiling use the /unsafe switch.
	static unsafe string AddPreString(string s)
	{
   		string str = String.Empty;
   
  		fixed(char* pre = "A") 
  		{
        return (s + *pre);
   		 }
	}


[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine(preString.AddPreString("PostString"));
		}
}
