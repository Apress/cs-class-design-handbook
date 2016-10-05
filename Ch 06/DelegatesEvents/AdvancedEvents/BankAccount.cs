using System;

public delegate void BankTransactionEventHandler(BankAccount sender, BankTransactionEventArgs args);

public class BankTransactionEventArgs : EventArgs
{
	public BankTransactionEventArgs(double amount)
	{
		mAmount = amount;
	}

	private double mAmount;
	public double Amount
	{
		get{return mAmount;}
	}
}

public class BankAccount
{
	public BankAccount(string name)
	{
		mBalance = 0;
		mAccountName = name;
	}
	public event EventHandler Overdrawn;
	public static event EventHandler ThresholdChanged;
	public event BankTransactionEventHandler LargeDeposit;

	private double mBalance;
	private string mAccountName;
	private static double mThreshold = 10000;

	public string Name{get{return mAccountName;}}
	public double Balance{get{return mBalance;}}
	public static double Threshold
	{
		set
		{
			mThreshold = value;
			if (ThresholdChanged != null)
			{
				ThresholdChanged(null, EventArgs.Empty);
			}
		}
		get{return mThreshold;}
	}

	public void Credit(double Amount)
	{
		mBalance += Amount;
		if (Amount >= mThreshold)
		{
			if (LargeDeposit != null)
			{
				LargeDeposit(this, new BankTransactionEventArgs(Amount));
			}
		}
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
	public override string ToString()
	{
		return mAccountName;
	}
}
