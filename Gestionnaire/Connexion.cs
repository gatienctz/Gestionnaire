using System;
using System.Windows.Forms;
using Gestionnaire.manager;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class Form1 : Form
    {

        private Profil _myProfil;
        public Form1()
        {
            InitializeComponent();
        }

        private void Connection()
        {
            Profil? user;
            //Vérification des informations de connection.
            if ((user = Profil.Connection(tbLogin.Text, PasswordManager.EncryptMd5(tbPassword.Text))) != null)
            {//Si l'utilisateur à rentré les bonnes informations, son profil est connecté au gestionnaire.
                Hide();//On cache la fenêtre de connexion.
                Gestionnaire gest = new Gestionnaire(user);//Création de la fenêtre du gestionnaire.
                var dialogResult = gest.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    Close();//Lorsque l'on ferme la fenêtre du gestionnaire, on ferme aussi la fenêtre de connexion.
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
                var myUsb = (USBDeviceInfo) dfProfil.lbUSBDevices.SelectedItem;
                _myProfil = new Profil(dfProfil.tbLogin.Text, dfProfil.tbPassword.Text,
                    myUsb.DeviceID);
                _myProfil.WriteToFile();
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