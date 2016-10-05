using System;

public class BankAccount
{
	public BankAccount(string name)
	{
		mBalance = 0;
		mAccountName = name;
	}
	public event EventHandler Overdrawn;

	private double mBalance;
	private string mAccountName;

	public string Name{get{return mAccountName;}}
	public double Balance{get{return mBalance;}}

	public void Credit(double Amount)
	{
		mBalance += Amount;
	}

	public void Debit(double Amount)
	{
		mBalance -= Amount;
		if (mBalance < 0)
		{
			if (Overdrawn != null)
			{
				Overdrawn(this, new EventArgs());
			}
		}
	}
}
