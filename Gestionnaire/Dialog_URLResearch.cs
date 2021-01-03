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
            //TODO Utilise XPathNavigator xnav |||| xnav.Select(Xpath) et tu récupéres très facilement le mdp avec un xpath comme en cours
            
            //return le mdp
            return "jtebez";
        }
    }
}