// form1.cs
using System;
using System.Windows.Forms;

namespace SimpleWindowsApplication
{
    namespace MyNamespace
    {
        public class Form1 : System.Windows.Forms.Form
        {
            private System.ComponentModel.Container components = null;

            public Form1()
            {
                InitializeComponent();
            }

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

            private void InitializeComponent()
            {
                components = new System.ComponentModel.Container();
            }

            [STAThread]
            static void Main() 
            {
                Application.Run(new Form1());
            }
        }
    }
}
