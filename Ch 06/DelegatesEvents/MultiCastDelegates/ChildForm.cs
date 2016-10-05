using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

	/// <summary>
	/// Summary description for ChildForm.
	/// </summary>
public class ChildForm : System.Windows.Forms.Form
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	//private System.ComponentModel.Container components = null;

	public ChildForm()
	{
		//
		// Required for Windows Form Designer support
		//
		InitializeComponent();

		//
		// TODO: Add any constructor code after InitializeComponent call
		//
	}

		#region Windows Form Designer generated code
	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		// 
		// ChildForm
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(292, 273);
		this.Name = "ChildForm";
		this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "ChildForm";
		this.Closing += new System.ComponentModel.CancelEventHandler(this.ChildForm_Closing);
		this.Load += new System.EventHandler(this.ChildForm_Load);

	}
		#endregion

	private void ChildForm_Load(object sender, System.EventArgs e)
	{
		// Display the current time in the window's title bar
		this.Text = "Created " + DateTime.Now.ToLongTimeString();
	}

	/* ----------------------------------------------------------------
		 This method will be called via multicast delegate in main form
		 ----------------------------------------------------------------*/
	public string Repaint(Color theColor) 
	{
		// Set the color for this form, and update the caption bar
		this.BackColor = theColor;
		this.Text = "Updated " + DateTime.Now.ToLongTimeString();
		return this.Text;

	}

	/* ----------------------------------------------------------------
		 Handle the Cancel event for this form
		 ----------------------------------------------------------------*/
	private void ChildForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
	{
		// Tell the main form we are closing, so the main form can 
		// remove us from its multicast delegate
		Mainform MyOwner = (Mainform)this.Owner;
		MyOwner.ChildFormClosing(this);

	}

}

