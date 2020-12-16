using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnecte_Click(object sender, EventArgs e)
        {
            
        }

        private void linklCreateProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogForm_Profil dfProfil = new DialogForm_Profil();
            DialogResult dialogResult = dfProfil.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Profil newProfil = new Profil(dfProfil.tbLogin.Text, dfProfil.tbPassword.Text);
                newProfil.writeProfilToFile();
            }
        }
    }
}