using System;
using System.Windows.Forms;

namespace Gestionnaire
{
    public partial class Dialog_AddEntry : Form
    {
        public Dialog_AddEntry()
        {
            InitializeComponent();
        }

        private void rbtnGenerate_CheckedChanged(object sender, EventArgs e)
        {
            panelGenerator.Enabled = rbtnGenerate.Checked;
        }

        private void rbtnSaisie_CheckedChanged(object sender, EventArgs e)
        {
            panelSaisie.Enabled = rbtnSaisie.Checked;
        }
    }
}