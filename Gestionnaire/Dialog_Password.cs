using System;
using System.Timers;
using System.Windows.Forms;

namespace Gestionnaire
{
    public partial class Dialog_Password : Form
    {
        public Dialog_Password(string password)
        {
            InitializeComponent();
            richTextBox1.Text = password;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Close();
        }
    }
}