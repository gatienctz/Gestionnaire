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
            bool connecte = Profil.isConnectionCorrect(tbLogin.Text, Profil.encryptMD5(tbPassword.Text));
            if (connecte)
            {
                MessageBox.Show("Connecté !", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur, nom d'utilisateur ou mot de passe incorrect !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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