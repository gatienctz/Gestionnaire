using System;
using System.Windows.Forms;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class Dialog_DelEntry : Form
    {
        public Dialog_DelEntry(Entry e)
        {
            InitializeComponent();
            lblEntryToDelete.Text = e.deleteMessage();
        }

        private void btConfirmer_Click(object sender, EventArgs e)
        {
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
        }
    }
}