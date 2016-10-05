using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AdvancedEvents
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class BankManagerForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtAccName;
		private System.Windows.Forms.Button btnAddAccount;
		private System.Windows.Forms.Label lblAccName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.Button btnUnlog;
		private System.Windows.Forms.TextBox txtEventLog;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox lstUnlogged;
		private System.Windows.Forms.ListBox lstLogged;
		private System.Windows.Forms.Button btnSetThreshold;
		private System.Windows.Forms.TextBox txtThreshold;
		private System.Windows.Forms.Label lblThreshold;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BankManagerForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.txtAccName = new System.Windows.Forms.TextBox();
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.lblAccName = new System.Windows.Forms.Label();
			this.lstUnlogged = new System.Windows.Forms.ListBox();
			this.lstLogged = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLog = new System.Windows.Forms.Button();
			this.btnUnlog = new System.Windows.Forms.Button();
			this.txtEventLog = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtThreshold = new System.Windows.Forms.TextBox();
			this.btnSetThreshold = new System.Windows.Forms.Button();
			this.lblThreshold = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtAccName
			// 
			this.txtAccName.Location = new System.Drawing.Point(16, 24);
			this.txtAccName.Name = "txtAccName";
			this.txtAccName.Size = new System.Drawing.Size(168, 20);
			this.txtAccName.TabIndex = 0;
			this.txtAccName.Text = "";
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.Location = new System.Drawing.Point(200, 24);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.TabIndex = 1;
			this.btnAddAccount.Text = "Add account";
			this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
			// 
			// lblAccName
			// 
			this.lblAccName.Location = new System.Drawing.Point(16, 8);
			this.lblAccName.Name = "lblAccName";
			this.lblAccName.Size = new System.Drawing.Size(112, 16);
			this.lblAccName.TabIndex = 2;
			this.lblAccName.Text = "New account name:";
			// 
			// lstUnlogged
			// 
			this.lstUnlogged.Location = new System.Drawing.Point(16, 88);
			this.lstUnlogged.Name = "lstUnlogged";
			this.lstUnlogged.Size = new System.Drawing.Size(136, 95);
			this.lstUnlogged.TabIndex = 3;
			// 
			// lstLogged
			// 
			this.lstLogged.Location = new System.Drawing.Point(248, 88);
			this.lstLogged.Name = "lstLogged";
			this.lstLogged.Size = new System.Drawing.Size(144, 95);
			this.lstLogged.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Unlogged accounts:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(272, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Logged accounts:";
			// 
			// btnLog
			// 
			this.btnLog.Location = new System.Drawing.Point(168, 96);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(64, 23);
			this.btnLog.TabIndex = 7;
			this.btnLog.Text = "Log >>";
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			// 
			// btnUnlog
			// 
			this.btnUnlog.Location = new System.Drawing.Point(168, 136);
			this.btnUnlog.Name = "btnUnlog";
			this.btnUnlog.Size = new System.Drawing.Size(64, 23);
			this.btnUnlog.TabIndex = 8;
			this.btnUnlog.Text = "<< Unlog";
			this.btnUnlog.Click += new System.EventHandler(this.btnUnlog_Click);
			// 
			// txtEventLog
			// 
			this.txtEventLog.Location = new System.Drawing.Point(16, 208);
			this.txtEventLog.Multiline = true;
			this.txtEventLog.Name = "txtEventLog";
			this.txtEventLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtEventLog.Size = new System.Drawing.Size(376, 136);
			this.txtEventLog.TabIndex = 9;
			this.txtEventLog.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Event log:";
			// 
			// txtThreshold
			// 
			this.txtThreshold.Location = new System.Drawing.Point(16, 368);
			this.txtThreshold.Name = "txtThreshold";
			this.txtThreshold.TabIndex = 11;
			this.txtThreshold.Text = "10000";
			// 
			// btnSetThreshold
			// 
			this.btnSetThreshold.Location = new System.Drawing.Point(128, 368);
			this.btnSetThreshold.Name = "btnSetThreshold";
			this.btnSetThreshold.Size = new System.Drawing.Size(152, 23);
			this.btnSetThreshold.TabIndex = 12;
			this.btnSetThreshold.Text = "Set new threshold value";
			this.btnSetThreshold.Click += new System.EventHandler(this.btnSetThreshold_Click);
			// 
			// lblThreshold
			// 
			this.lblThreshold.Location = new System.Drawing.Point(16, 352);
			this.lblThreshold.Name = "lblThreshold";
			this.lblThreshold.Size = new System.Drawing.Size(160, 16);
			this.lblThreshold.TabIndex = 13;
			this.lblThreshold.Text = "New large deposits threshold:";
			// 
			// BankManagerForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 397);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblThreshold,
																		  this.btnSetThreshold,
																		  this.txtThreshold,
																		  this.label3,
																		  this.txtEventLog,
																		  this.btnUnlog,
																		  this.btnLog,
																		  this.label2,
																		  this.label1,
																		  this.lstLogged,
																		  this.lstUnlogged,
																		  this.lblAccName,
																		  this.btnAddAccount,
																		  this.txtAccName});
			this.Name = "BankManagerForm";
			this.Text = "Bank manager form";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new BankManagerForm());
		}

		private void btnAddAccount_Click(object sender, System.EventArgs e)
		{
			if (txtAccName.Text.Trim() == "")
			{
				MessageBox.Show("Please enter an account name first.");
			}
			else
			{
				BankAccountForm NewAccount = new BankAccountForm(txtAccName.Text);
				NewAccount.Show();
				lstUnlogged.Items.Add(NewAccount.BankAccount);
			}
		}

		private void btnLog_Click(object sender, System.EventArgs e)
		{
			if (lstUnlogged.SelectedItem is BankAccount)
			{
				BankAccount b = (BankAccount)lstUnlogged.SelectedItem;
				b.Overdrawn += new EventHandler(OverdrawnHandler);
				b.LargeDeposit += new BankTransactionEventHandler(this.LargeDepositHandler);

				lstLogged.Items.Add(b);
				lstUnlogged.Items.Remove(b);
			}
		
		}
		private void btnUnlog_Click(object sender, System.EventArgs e)
		{
			if (lstLogged.SelectedItem is BankAccount)
			{
				BankAccount b = (BankAccount)lstLogged.SelectedItem ;
				b.Overdrawn -= new EventHandler(this.OverdrawnHandler);
				b.LargeDeposit -= new BankTransactionEventHandler(this.LargeDepositHandler);

				lstLogged.Items.Remove(b);
				lstUnlogged.Items.Add(b);
			}
		}


		private void OverdrawnHandler(object sender, System.EventArgs e)
		{
			BankAccount b = (BankAccount)sender;
            AppendLog(String.Format("The bank account {0} has been overdrawn. Current balance: {1}", b.Name, b.Balance));
		}
		private void LargeDepositHandler(BankAccount sender, BankTransactionEventArgs args)
		{
			AppendLog(String.Format("The bank account {0} has received a large deposit of {2}. Current balance: {1}", sender.Name, sender.Balance, args.Amount));
		}

		private void AppendLog(string msg)
		{
			txtEventLog.Text += String.Format("{0}\r\n", msg);
			txtEventLog.Refresh();
		}

		private void btnSetThreshold_Click(object sender, System.EventArgs e)
		{
			BankAccount.Threshold = Double.Parse(txtThreshold.Text);
		}

	}
}
