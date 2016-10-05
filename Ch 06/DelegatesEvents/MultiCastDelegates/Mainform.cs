
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


// Define the delegate
delegate string ChangeColorDelegate(Color aColor);


	/// <summary>
	/// Summary description for Form1.
	/// </summary>
public class Mainform : System.Windows.Forms.Form
{
	private System.Windows.Forms.Label lblHeight;
	private System.Windows.Forms.Label lblWidth;
	private System.Windows.Forms.Label lblLeft;
	private System.Windows.Forms.Label lblTop;
	private System.Windows.Forms.TextBox txtHeight;
	private System.Windows.Forms.TextBox txtWidth;
	private System.Windows.Forms.TextBox txtTop;
	private System.Windows.Forms.TextBox txtLeft;
	private System.Windows.Forms.Button btnAddWindow;
	private System.Windows.Forms.Button btnChangeColor;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.Container components = null;
	private System.Windows.Forms.StatusBar sbStatus;

	private ChangeColorDelegate mAllRepaintMethods;

	public Mainform()
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
		this.lblHeight = new System.Windows.Forms.Label();
		this.lblWidth = new System.Windows.Forms.Label();
		this.lblLeft = new System.Windows.Forms.Label();
		this.lblTop = new System.Windows.Forms.Label();
		this.txtHeight = new System.Windows.Forms.TextBox();
		this.txtWidth = new System.Windows.Forms.TextBox();
		this.txtTop = new System.Windows.Forms.TextBox();
		this.txtLeft = new System.Windows.Forms.TextBox();
		this.btnAddWindow = new System.Windows.Forms.Button();
		this.btnChangeColor = new System.Windows.Forms.Button();
		this.sbStatus = new System.Windows.Forms.StatusBar();
		this.SuspendLayout();
		// 
		// lblHeight
		// 
		this.lblHeight.Location = new System.Drawing.Point(128, 48);
		this.lblHeight.Name = "lblHeight";
		this.lblHeight.Size = new System.Drawing.Size(40, 23);
		this.lblHeight.TabIndex = 15;
		this.lblHeight.Text = "Height";
		// 
		// lblWidth
		// 
		this.lblWidth.Location = new System.Drawing.Point(8, 48);
		this.lblWidth.Name = "lblWidth";
		this.lblWidth.Size = new System.Drawing.Size(48, 23);
		this.lblWidth.TabIndex = 14;
		this.lblWidth.Text = "Width";
		// 
		// lblLeft
		// 
		this.lblLeft.Location = new System.Drawing.Point(8, 16);
		this.lblLeft.Name = "lblLeft";
		this.lblLeft.Size = new System.Drawing.Size(48, 23);
		this.lblLeft.TabIndex = 13;
		this.lblLeft.Text = "Left";
		// 
		// lblTop
		// 
		this.lblTop.Location = new System.Drawing.Point(128, 16);
		this.lblTop.Name = "lblTop";
		this.lblTop.Size = new System.Drawing.Size(32, 23);
		this.lblTop.TabIndex = 12;
		this.lblTop.Text = "Top";
		// 
		// txtHeight
		// 
		this.txtHeight.Location = new System.Drawing.Point(168, 48);
		this.txtHeight.Name = "txtHeight";
		this.txtHeight.Size = new System.Drawing.Size(32, 20);
		this.txtHeight.TabIndex = 11;
		this.txtHeight.Text = "30";
		// 
		// txtWidth
		// 
		this.txtWidth.Location = new System.Drawing.Point(56, 48);
		this.txtWidth.Name = "txtWidth";
		this.txtWidth.Size = new System.Drawing.Size(32, 20);
		this.txtWidth.TabIndex = 10;
		this.txtWidth.Text = "30";
		// 
		// txtTop
		// 
		this.txtTop.Location = new System.Drawing.Point(168, 16);
		this.txtTop.Name = "txtTop";
		this.txtTop.Size = new System.Drawing.Size(32, 20);
		this.txtTop.TabIndex = 9;
		this.txtTop.Text = "120";
		// 
		// txtLeft
		// 
		this.txtLeft.Location = new System.Drawing.Point(56, 16);
		this.txtLeft.Name = "txtLeft";
		this.txtLeft.Size = new System.Drawing.Size(32, 20);
		this.txtLeft.TabIndex = 8;
		this.txtLeft.Text = "120";
		// 
		// btnAddWindow
		// 
		this.btnAddWindow.Location = new System.Drawing.Point(272, 16);
		this.btnAddWindow.Name = "btnAddWindow";
		this.btnAddWindow.Size = new System.Drawing.Size(112, 23);
		this.btnAddWindow.TabIndex = 16;
		this.btnAddWindow.Text = "Add windows";
		this.btnAddWindow.Click += new System.EventHandler(this.btnAddWindow_Click);
		// 
		// btnChangeColor
		// 
		this.btnChangeColor.Location = new System.Drawing.Point(272, 56);
		this.btnChangeColor.Name = "btnChangeColor";
		this.btnChangeColor.Size = new System.Drawing.Size(112, 23);
		this.btnChangeColor.TabIndex = 17;
		this.btnChangeColor.Text = "Change color";
		this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
		// 
		// sbStatus
		// 
		this.sbStatus.Location = new System.Drawing.Point(0, 95);
		this.sbStatus.Name = "sbStatus";
		this.sbStatus.Size = new System.Drawing.Size(408, 22);
		this.sbStatus.TabIndex = 18;
		// 
		// Mainform
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(408, 117);
		this.Controls.AddRange(new System.Windows.Forms.Control[] {
																	  this.sbStatus,
																	  this.btnChangeColor,
																	  this.btnAddWindow,
																	  this.lblHeight,
																	  this.lblWidth,
																	  this.lblLeft,
																	  this.lblTop,
																	  this.txtHeight,
																	  this.txtWidth,
																	  this.txtTop,
																	  this.txtLeft});
		this.Name = "Mainform";
		this.Text = "Multicast delegate demo";
		this.ResumeLayout(false);

	}
		#endregion

	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main() 
	{
		Application.Run(new Mainform());
	}

	private void btnAddWindow_Click(object sender, System.EventArgs e)
	{
		// Are any text fields blank?
		if (txtLeft.Text.Length == 0 || txtTop.Text.Length == 0 || 
			txtWidth.Text.Length == 0 || txtHeight.Text.Length == 0)
		{
			MessageBox.Show("Please fill in all text boxes", 
				"Error",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			return;
		}
        
		ChildForm aChildForm = new ChildForm();
		aChildForm.Owner = this;
		aChildForm.DesktopBounds = new Rectangle(
			Int32.Parse(txtLeft.Text), 
			Int32.Parse(txtTop.Text), 
			Int32.Parse(txtWidth.Text), 
			Int32.Parse(txtHeight.Text));
		aChildForm.Show();

		// Create a new delegate for the child form's Repaint method
		ChangeColorDelegate newDelegate = new ChangeColorDelegate(aChildForm.Repaint);


		// Combine new delegate into the multicast delegate
		mAllRepaintMethods = (ChangeColorDelegate)System.Delegate.Combine(mAllRepaintMethods, 
			newDelegate);

		// Use multicast delegate to count the child forms 
		sbStatus.Text = "Created child form " +
			mAllRepaintMethods.GetInvocationList().Length + ".";

	}

	private void btnChangeColor_Click(object sender, System.EventArgs e)
	{
		if( mAllRepaintMethods == null) 
		{
			MessageBox.Show("There are no child forms to change.", 
				"Error changing color", 
				MessageBoxButtons.OK, 
				MessageBoxIcon.Error);

		}
		else
		{
			// Ask user to choose a color
			ColorDialog dlgColor = new ColorDialog();
			dlgColor.ShowDialog();

			// Invoke multicast delegate, to repaint all the child forms
			mAllRepaintMethods(dlgColor.Color );

			// Use multicast delegate to count the child forms 
			sbStatus.Text = "Updated " +
				mAllRepaintMethods.GetInvocationList().Length +
				" child form(s).";

		}


	}

	public void ChildFormClosing(ChildForm aChildForm )
	{
		// Create a delegate for the ChildForm that is closing
		ChangeColorDelegate unneededDelegate = new ChangeColorDelegate( aChildForm.Repaint);

		// Remove the delegate from the multicast delegate
		mAllRepaintMethods = (ChangeColorDelegate)System.Delegate.Remove(mAllRepaintMethods, unneededDelegate);

		// If multicast delegate is Nothing, there are no child forms left
		if (mAllRepaintMethods == null)
		{

			sbStatus.Text = "Final child form has been closed.";
		}
		else
		{
			// Use multicast delegate to count the child forms 
			sbStatus.Text = "Child form closed, " + mAllRepaintMethods.GetInvocationList().Length  + " form(s) remaining.";
		}


	}
}
