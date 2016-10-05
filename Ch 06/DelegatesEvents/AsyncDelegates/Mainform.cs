using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Xml;

namespace AsyncDelegates
{
	delegate void DocumentLoad(string fileUrl);

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Mainform : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.StatusBar sbStatus;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Button btnSync;
		private System.Windows.Forms.Button btnAsync;

		private DateTime mActionStarted;
		private DateTime mLastTiming;
		private System.Windows.Forms.Button btnCallback;
		private ArrayList mUrlList;

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
			this.sbStatus = new System.Windows.Forms.StatusBar();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.btnSync = new System.Windows.Forms.Button();
			this.btnAsync = new System.Windows.Forms.Button();
			this.btnCallback = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// sbStatus
			// 
			this.sbStatus.Location = new System.Drawing.Point(0, 95);
			this.sbStatus.Name = "sbStatus";
			this.sbStatus.Size = new System.Drawing.Size(408, 22);
			this.sbStatus.TabIndex = 18;
			// 
			// txtLog
			// 
			this.txtLog.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtLog.Location = new System.Drawing.Point(208, 0);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(200, 96);
			this.txtLog.TabIndex = 19;
			this.txtLog.Text = "";
			this.txtLog.WordWrap = false;
			// 
			// btnSync
			// 
			this.btnSync.Location = new System.Drawing.Point(8, 8);
			this.btnSync.Name = "btnSync";
			this.btnSync.Size = new System.Drawing.Size(192, 23);
			this.btnSync.TabIndex = 20;
			this.btnSync.Text = "Load synchronous";
			this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
			// 
			// btnAsync
			// 
			this.btnAsync.Location = new System.Drawing.Point(8, 40);
			this.btnAsync.Name = "btnAsync";
			this.btnAsync.Size = new System.Drawing.Size(192, 23);
			this.btnAsync.TabIndex = 21;
			this.btnAsync.Text = "Load asynchronous";
			this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
			// 
			// btnCallback
			// 
			this.btnCallback.Location = new System.Drawing.Point(8, 72);
			this.btnCallback.Name = "btnCallback";
			this.btnCallback.Size = new System.Drawing.Size(192, 23);
			this.btnCallback.TabIndex = 22;
			this.btnCallback.Text = "Load asynchronous with callback";
			this.btnCallback.Click += new System.EventHandler(this.btnCallback_Click);
			// 
			// Mainform
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 117);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnCallback,
																		  this.btnAsync,
																		  this.btnSync,
																		  this.txtLog,
																		  this.sbStatus});
			this.Name = "Mainform";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Mainform_Load);
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

		private void ClearLog()
		{
			txtLog.Text = "";
			txtLog.Refresh();
			mActionStarted = DateTime.Now;
			mLastTiming = mActionStarted;
		}
		private void AppendLog(string msg)
		{
			DateTime TimeNow = DateTime.Now;
			TimeSpan Elapsed = TimeNow - mActionStarted;
			TimeSpan ElapsedSinceLast = TimeNow - mLastTiming;
			mLastTiming = TimeNow;

			txtLog.Text += String.Format("{0:00000.0} {1:00000.0} {2}\r\n", Elapsed.TotalMilliseconds, ElapsedSinceLast.TotalMilliseconds, msg);
			txtLog.Refresh();

		}

		private void btnSync_Click(object sender, System.EventArgs e)
		{
			// Clear the output
			ClearLog();

			// Initialise an array of XmlDocument objects
			XmlDocument[] Documents = new XmlDocument[mUrlList.Count];
			for (int i = 0; i<mUrlList.Count; i++)
			{
				Documents[i] = new XmlDocument();
				// Both the loading of the content over the network and the parsing of
				// this content happens in the next line.
				Documents[i].Load((string)mUrlList[i]);
				AppendLog("Loaded document from " + mUrlList[i]);
			}

		}

		private void Mainform_Load(object sender, System.EventArgs e)
		{
			// Initialising a list of three Urls containing valid Xml content
            mUrlList = new ArrayList();
			mUrlList.Add("http://slashdot.org/slashdot.rdf");
			mUrlList.Add("http://slashdot.org/science.rdf");
			mUrlList.Add("http://slashdot.org/books.rdf");
		}

		private void btnAsync_Click(object sender, System.EventArgs e)
		{
			ClearLog();

			// As we will now be working with several objects at the same time,
			// we declare arrays of XmlDocument, Delegate and the IAsyncResult
			XmlDocument[] Documents = new XmlDocument[mUrlList.Count];
			DocumentLoad[] Delegates = new DocumentLoad[mUrlList.Count];
			
			// VS.NET does not support arrays of interface type with 
			// Intellisense, but this code is valid C# and compiles fine
			IAsyncResult[] Tickets = new IAsyncResult[mUrlList.Count];
			
			for (int i = 0; i<mUrlList.Count; i++)
			{
				Documents[i] = new XmlDocument();
				Delegates[i] = new DocumentLoad(Documents[i].Load);
				// The next line starts the loading of the XmlDocument on a 
				// different thread. We don't have to wait for its completion now.
				// The two null parameters at the end are for use with callback functions.
				Tickets[i] = Delegates[i].BeginInvoke((string)mUrlList[i], null, null);
				AppendLog("Started loading document from " + mUrlList[i]);
			}
			for (int i = 0; i<mUrlList.Count; i++)
			{
				// Force to wait here until the call is completed. We 
				// could have called BeginInvoke multiple times on the 
				// same delegate instance, so we need the ticket (of 
				// type IAsyncResult) to specify which call we mean exactly.
				Delegates[i].EndInvoke(Tickets[i]);
				AppendLog("Loaded document from " + mUrlList[i]);
			}
		}		

		private void btnCallback_Click(object sender, System.EventArgs e)
		{
			ClearLog();

			XmlDocument[] Documents = new XmlDocument[mUrlList.Count];
			
			for (int i = 0; i<mUrlList.Count; i++)
			{
				Documents[i] = new XmlDocument();
				DocumentLoad TheDelegate = new DocumentLoad(Documents[i].Load);
				AsyncCallback CallbackDelegate = new AsyncCallback(this.ReadyLoading);

				// We start the loading of the XMLDocument, passing it a delegate
				// for calling the ReadyLoading method when it is ready. A reference
				// to the current XmlDocument is also passed in. This will be passed
				// to the callback method as the AsyncState property of the IAsyncResult.
				TheDelegate.BeginInvoke((string)mUrlList[i], CallbackDelegate, Documents[i]);
				AppendLog("Started loading document from " + mUrlList[i]);
			}
		
		}

		/// <summary>
		/// This is the actual callback method. It has a predefined signature 
		/// to fit the standard delegate System.AsyncCallback. We never call this method ourselves.
		/// </summary>
		/// <param name="r"></param>
		private void ReadyLoading(IAsyncResult r)
		{
			if (r.AsyncState is XmlDocument)
			{
				XmlDocument doc = (XmlDocument)r.AsyncState;
				AppendLog("Loaded " + doc.BaseURI);
			}
		}

	}

}
