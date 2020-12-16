using System;
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
        }

        private ErrorProvider _errorProvider = new ErrorProvider();

        private void tbLogin_Validating(object sender, CancelEventArgs e)
        {
            isLoginValide();
            btnValidate.Enabled = isFormValide();
        }

        private bool isLoginValide()
        {
            bool status = true;
            if (tbLogin.Text == "")
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
            

            return status;
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            isPasswordValide();
            btnValidate.Enabled = isFormValide();
        }

        private bool isPasswordValide()
        {
            bool status = true;
            if (tbPassword.Text == "")
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
        

        private void tbLogin_Validated(object sender, EventArgs e)
        {
            isLoginValide();
            btnValidate.Enabled = isFormValide();
        }
    }
}