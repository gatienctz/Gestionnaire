using System;
using System.Windows.Forms;

namespace Gestionnaire
{
    public partial class Dialog_Password : Form
    {
        public Dialog_Password(string password)
        {
            InitializeComponent();
            label1.Text = password;
        }
        
    }
}