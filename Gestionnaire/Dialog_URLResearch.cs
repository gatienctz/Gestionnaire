using System;
using System.Windows.Forms;

namespace Gestionnaire
{
    public partial class Dialog_URLResearch : Form
    {
        public Dialog_URLResearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password=ResearchPassword();
            Dialog_Password dde = new Dialog_Password(password);
            DialogResult res = dde.ShowDialog();
        }

        private string ResearchPassword()
        {
            //TODO Parcourir le bon xml pour trouver le mdp correspondant à
            //textBox1.Text;
            
            //return le mdp
            return "jtebez";
        }
    }
}