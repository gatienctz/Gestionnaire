using System;
using System.Windows.Forms;
using Gestionnaire.manager;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connection()
        {
            bool connecte = Profil.isConnectionCorrect(tbLogin.Text, PasswordManager.EncryptMd5(tbPassword.Text));
            if (connecte)
            {
                //MessageBox.Show("Connecté !", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Gestionnaire gest = new Gestionnaire();
                var dialogResult = gest.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Erreur, nom d'utilisateur ou mot de passe incorrect !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnConnecte_Click(object sender, EventArgs e)
        {
            connection();
        }

        private void linklCreateProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogForm_Profil dfProfil = new DialogForm_Profil();
            DialogResult dialogResult = dfProfil.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Profil newProfil = new Profil(dfProfil.tbLogin.Text, dfProfil.tbPassword.Text,dfProfil.lbUSBDevices.SelectedItems[0].ToString());
                newProfil.writeProfilToFile();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connection();
            }
        }
    }
}