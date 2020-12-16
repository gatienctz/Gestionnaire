using System;
using System.Windows.Forms;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class DialogForm_Profil : Form
    {
        public DialogForm_Profil()
        {
            InitializeComponent();
        }

        public bool isValide()
        {
            bool userValide = Profil.isLoginValide(tbLogin.Text);
            bool passValide = Profil.isPasswordValide(tbPassword.Text);
            bool USBValide = lbUSBDevices.SelectedIndex == -1;
            return userValide && passValide && USBValide;
        }

        private void DialogForm_Profil_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (!isValide())
            {
                e.Cancel = true;
                MessageBox.Show("Erreur !", "Le formulaire n'est pas valide !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                e.Cancel = false;
            }*/
        }
    }
}