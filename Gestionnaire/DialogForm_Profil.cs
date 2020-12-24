using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class DialogForm_Profil : Form
    {
        public DialogForm_Profil()
        {
            InitializeComponent();
            List<USBDeviceInfo> listUSB=UsbDeviceInfoMain.GetUSBDevices();
            int cmp = 0;
            int selected_item = -1; //Ici on va prendre le dernier ayant Disposotif de stockage de masse USB comme description
            foreach (var entry in listUSB)
            {
                lbUSBDevices.Items.Add("Device ID:"+entry.DeviceID+" , PNP Device ID: "+entry.PnpDeviceID+", Description: "+entry.Description);
                if (entry.Description == "Dispositif de stockage de masse USB") selected_item = cmp;
                cmp++;
            }
            if (selected_item!=-1) lbUSBDevices.SetSelected(selected_item, true);
        }

        private ErrorProvider _errorProvider = new ErrorProvider();

        private void loginValidating()
        {
            isLoginValide();
            btnValidate.Enabled = isFormValide();
        }
        
        private void tbLogin_Validating(object sender, CancelEventArgs e)
        {
            loginValidating();
        }

        private bool isLoginValide()
        {
            if (String.IsNullOrEmpty(tbLogin.Text))
            {
                _errorProvider.SetError(tbLogin, "Veuillez saisir un nom d'utilisateur.");
                return false;
            }
            
            if (!Profil.isLoginValide(tbLogin.Text))
            {
                _errorProvider.SetError(tbLogin, "Le nom d'utilisateur doit contenir entre 3 et 20 caractères alpha numériques (a-zA-Z0-9)");
                return false;
            }
            if (Profil.isLoginExist(tbLogin.Text))
            {
                _errorProvider.SetError(tbLogin,
                    "Le nom d'utilisateur existe déjà, veuillez en choisir un nouveau.");
                return false;
            }
            _errorProvider.SetError(tbLogin, "");
            

            return true;
        }

        private void passwordValidating()
        {
            isPasswordValide();
            btnValidate.Enabled = isFormValide();
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            passwordValidating();
        }

        private bool isPasswordValide()
        {
            bool status = true;
            if (String.IsNullOrEmpty(tbPassword.Text))
            {
                _errorProvider.SetError(tbPassword, "Veuillez saisir un mot de passe.");
                status = false;
            }
            else
            {
                if (!Profil.isLoginValide(tbPassword.Text))
                {
                    _errorProvider.SetError(tbPassword, "Le mot de passe est mal formaté.");
                    status = false;
                }
                else {
                    _errorProvider.SetError(tbPassword, "");
                }
            }

            return status;
        }

        private bool isFormValide()
        {
            return isLoginValide() && isPasswordValide();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            //loginValidating();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            //passwordValidating();
        }

        private void lbUSBDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}