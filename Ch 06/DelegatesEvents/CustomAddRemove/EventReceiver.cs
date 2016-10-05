using System;
using System.Windows.Forms;

namespace CustomAddRemove
{
	/// <summary>
	/// Summary description for EventReceiver.
	/// </summary>
	public class EventReceiver
	{
		private TextBox mTextBox;
private string mName;

		public EventReceiver(TextBox tb, string name)
		{
            mTextBox = tb;
			mName = name;
		}


		public void EventHandler(object sender, EventArgs e)
		{
			mTextBox.Text += String.Format("Object '{0}' received event.\r\n", mName);
		}

	}
}
