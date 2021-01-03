using System;
using System.Windows.Forms;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class Dialog_URLResearch : Form
    {
        private Entries _entries;
        public Dialog_URLResearch(Entries _entries)
        {
            InitializeComponent();
            this._entries = _entries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password=ResearchPassword();
            Dialog_Password dde = new Dialog_Password(password);
            DialogResult res = dde.ShowDialog();
        }

        private string ResearchPassword()
        {
            foreach (var entry in _entries.Entry)
            {
                if (entry.Url == textBox1.Text) return entry.Password;
            }
            return "Entrée introuvable";
        }
    }
}