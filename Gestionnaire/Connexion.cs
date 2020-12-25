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

        private void Connection()
        {
            bool connected = Profil.IsConnectionCorrect(tbLogin.Text, PasswordManager.EncryptMd5(tbPassword.Text));
            //Ici il suffit pas de savoir si il est connecté, mais aussi avec quel compte
            if (connected)
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
        }
        private void btnConnected_Click(object sender, EventArgs e)
        {
            Connection();
        }

        private void linklCreateProfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogForm_Profil dfProfil = new DialogForm_Profil();
            DialogResult dialogResult = dfProfil.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Profil newProfil = new Profil(dfProfil.tbLogin.Text, dfProfil.tbPassword.Text,dfProfil.lbUSBDevices.SelectedItems[0].ToString());
                newProfil.WriteProfilToFile();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Connection();
            }
        }
    }
}