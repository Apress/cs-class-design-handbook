using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

/// <summary>
/// Summary description for Form1.
/// </summary>
public class BankAccountForm : System.Windows.Forms.Form
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.Container components = null;
	private System.Windows.Forms.Button btnCredit;
	private System.Windows.Forms.Button btnDebit;
	private System.Windows.Forms.TextBox txtAmount;
	private System.Windows.Forms.Label lblAmount;

	private BankAccount mBankAccount;
	public BankAccountForm()
	{
		//
		// Required for Windows Form Designer support
		//
		InitializeComponent();

		mBankAccount = new BankAccount("Teun Duynstee");
		RefreshTitle();
        mBankAccount.Overdrawn += new EventHandler(this.OverdrawnHandlerMethod);
	}

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	protected override void Dispose( bool disposing )
	{
		if( disposing )
		{
			if (components != null) 
			{
				components.Dispose();
			}
		}
		base.Dispose( disposing );
	}

		#region Windows Form Designer generated code
	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		this.btnCredit = new System.Windows.Forms.Button();
		this.btnDebit = new System.Windows.Forms.Button();
		this.txtAmount = new System.Windows.Forms.TextBox();
		this.lblAmount = new System.Windows.Forms.Label();
		this.SuspendLayout();
		// 
		// btnCredit
		// 
		this.btnCredit.Location = new System.Drawing.Point(8, 8);
		this.btnCredit.Name = "btnCredit";
		this.btnCredit.TabIndex = 0;
		this.btnCredit.Text = "Credit";
		this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
		// 
		// btnDebit
		// 
		this.btnDebit.Location = new System.Drawing.Point(88, 8);
		this.btnDebit.Name = "btnDebit";
		this.btnDebit.TabIndex = 1;
		this.btnDebit.Text = "Debit";
		this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
		// 
		// txtAmount
		// 
		this.txtAmount.Location = new System.Drawing.Point(64, 40);
		this.txtAmount.Name = "txtAmount";
		this.txtAmount.TabIndex = 2;
		this.txtAmount.Text = "0";
		// 
		// lblAmount
		// 
		this.lblAmount.Location = new System.Drawing.Point(16, 40);
		this.lblAmount.Name = "lblAmount";
		this.lblAmount.Size = new System.Drawing.Size(48, 16);
		this.lblAmount.TabIndex = 4;
		this.lblAmount.Text = "Amount:";
		// 
		// BankAccountForm
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(320, 69);
		this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.lblAmount,
																	  this.txtAmount,
																	  this.btnDebit,
																	  this.btnCredit});
		this.Name = "BankAccountForm";
		this.ResumeLayout(false);

	}
		#endregion

	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main() 
	{
		Application.Run(new BankAccountForm());
	}

	private void RefreshTitle()
	{
		this.Text = String.Format("Account {0}, balance: {1}", mBankAccount.Name, mBankAccount.Balance ); 
	}

	private void btnCredit_Click(object sender, System.EventArgs e)
	{
      mBankAccount.Credit(Double.Parse(txtAmount.Text));
  	  RefreshTitle();
	}

	private void btnDebit_Click(object sender, System.EventArgs e)
	{
		mBankAccount.Debit(Double.Parse(txtAmount.Text));
		RefreshTitle();
	}

	private void OverdrawnHandlerMethod(object sender, System.EventArgs e)
	{
		MessageBox.Show("The bank account has been overdrawn. The current balance is " + mBankAccount.Balance,
			"Overdrawn",
			MessageBoxButtons.OK,
			MessageBoxIcon.Information);
	}
}
