using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Numch
{
    public partial class Help : Form
    {
        //Save all text into a string
        string fullText = System.IO.File.ReadAllText("C:\\Users\\eftap\\Downloads\\Numch[1.0]\\Numch[0.7]\\Numch\\bin\\Debug\\Usage Logs\\Info.txt");
        public Help()
        {
            InitializeComponent();
            text.Text = fullText;       //Write the info
            //Align to center
            text.SelectAll();
            text.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();        //Hide the form
            Sound.PlaySound("Back2");   //Play sound Back2
        }

        private void EnterText(object sender, EventArgs e)
        {
            lblHideCursor.Focus();  //Hide the caret
        }

        private void LeaveText(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;   //Reset the cursor
        }
    }
}
