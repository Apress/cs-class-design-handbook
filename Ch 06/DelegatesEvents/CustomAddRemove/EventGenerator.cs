using System;
using System.Windows.Forms;

namespace CustomAddRemove
{
	/// <summary>
	/// Summary description for EventGenerator.
	/// </summary>
	public class EventGenerator
	{
		protected TextBox mTextBox;

		private EventHandler mHappening;

		public virtual event EventHandler Happening
		{
			add
			{
				mHappening = (EventHandler)Delegate.Combine(mHappening, value);
				mTextBox.Text += "A new handler has registered for Happening\r\n";
			}
			remove
			{
				mHappening = (EventHandler)Delegate.Remove(mHappening, value);
				mTextBox.Text += "A new handler has unregistered for Happening\r\n";
			}
		}

		public EventGenerator(TextBox tb)
		{
			mTextBox = tb;
		}

		public void SimulateEvent()
		{
			mTextBox.Text += "EventGenerator is raising the event.\r\n";
			if (mHappening != null)
			{
				mHappening(this, EventArgs.Empty);
			}
		}
	}
}
