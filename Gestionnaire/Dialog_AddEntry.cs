using System;
using System.Linq;
using System.Windows.Forms;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class Dialog_AddEntry : Form
    {
        private ErrorProvider _errorProvider = new ErrorProvider();
        private Uri _UrlString;

        public string UrlString => _UrlString.ToString();

        public Dialog_AddEntry()
        {
            InitializeComponent();
        }

        private void rbtnGenerate_CheckedChanged(object sender, EventArgs e)
        {
            panelGenerator.Enabled = rbtnGenerate.Checked;
            btnOk.Enabled = IsFormValid();
        }

        private void rbtnSaisie_CheckedChanged(object sender, EventArgs e)
        {
            panelSaisie.Enabled = rbtnSaisie.Checked;
            btnOk.Enabled = IsFormValid();
        }

        private void trackbarLengthPwd_Scroll(object sender, EventArgs e)
        {
            lblLengthPwd.Text = trackbarLengthPwd.Value.ToString();
        }

        private string GetSpecialCharSelected()
        {
            var specialCharsText = groupBSpecialChar.Controls.OfType<CheckBox>()
                .Where(c => c.Checked)
                .Select(c => c.Text);
            return String.Join("", specialCharsText);
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblPwdGenerated.Text = MyUtils.GeneratePassword(Int32.Parse(lblLengthPwd.Text), checkMaj.Checked, checkDigit.Checked, GetSpecialCharSelected());
            btnOk.Enabled = IsFormValid();
        }
        
        /* ######## VALIDATING ######## */

        
        private bool IsNameValid(bool provideError)
        {
            var state = true;
            var errorString = "";
            
            if (String.IsNullOrEmpty(tbName.Text))
            {
                errorString = "Veuillez saisir un nom d'utilisateur.";
                state = false;
            }
            else
            {
                //TODO Créer un regex juste pour le nom de l'entrée 
                
                if (!Profil.IsValidLogin(tbName.Text))
                {
                    errorString = "Le nom d'utilisateur doit contenir entre 3 et 15 caractères alpha numériques (a-zA-Z0-9)";
                    state = false;
                }
            }
            if(provideError)
                _errorProvider.SetError(tbName, errorString);

            return state;
        }

        private void ValidatingName()
        {
            IsNameValid(true);
            btnOk.Enabled = IsFormValid();
        }
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            ValidatingName();
        }

        public bool IsUrlValide(bool provideError)
        {
            bool state = true;
            var errorString = "";

            if (String.IsNullOrEmpty(tbUrl.Text))
            {
                errorString = "Veuillez saisir une URL.";
                state = false;
            }
            else
            {
                if (!MyUtils.ValidHttpURL(tbUrl.Text, out _UrlString))
                {
                    errorString = "L'URL saisie est invalide. ex : https://www.google.com ";
                    state = false;
                }
            }
            if(provideError)
                _errorProvider.SetError(tbUrl, errorString);

            return state;
        }

        private void ValidatingUrl()
        {
            IsUrlValide(true);
            btnOk.Enabled = IsFormValid();
        }
        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            ValidatingUrl();
        }

        private bool IsLoginValid(bool provideError)
        {
            var state = true;
            var errorString = "";
            
            if (String.IsNullOrEmpty(tbUsername.Text))
            {
                errorString = "Veuillez saisir un nom d'utilisateur.";
                state = false;
            }
            
            if (!Profil.IsValidLogin(tbUsername.Text))
            {
                errorString = "Le nom d'utilisateur doit contenir entre 3 et 20 caractères alpha numériques (a-zA-Z0-9)";
                state = false;
            }
            
            if(provideError)
                _errorProvider.SetError(tbUsername, errorString);

            return state;
        }

        public void ValidatingLogin()
        {
            IsLoginValid(true);
            btnOk.Enabled = IsFormValid();
        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            ValidatingLogin();
        }

        private bool IsPasswordValid(bool provideError)
        {
            var state = true;
            var errorString = "";
            
            if(String.IsNullOrEmpty(tbPwd.Text))
            {
                errorString = "Veuillez saisir un mot de passe. Un générateur peut vous aider à en choisir un";
                state = false;
            }
            if(provideError)
                _errorProvider.SetError(tbPwd, errorString);
            return state;
        }
        
        private void ValidatingPassword()
        {
            IsPasswordValid(true);
            btnOk.Enabled = IsFormValid();
        }
        private void tbPwd_TextChanged(object sender, EventArgs e)
        {
            ValidatingPassword();
        }

        private bool IsSecondPasswordValide(bool provideError)
        {
            var state = true;
            var errorString = "";
            
            if (String.IsNullOrEmpty(tbPwd_second.Text))
            {
                errorString = "Veuillez resaisir votre mot de passe";
                state = false;
            }
            else
            {
                if (!tbPwd_second.Text.Equals(tbPwd.Text))
                {
                    errorString = "Le mot de passe doit être identique au premier.";
                    state = false;
                }
            }
            
            if(provideError)
                _errorProvider.SetError(tbPwd_second, errorString);

            return state;
        }

        private void ValidatingSecondPassword()
        {
            IsSecondPasswordValide(true);
            btnOk.Enabled = IsFormValid();
        }
        
        private void tbPwd_second_TextChanged(object sender, EventArgs e)
        {
            ValidatingSecondPassword();
        }

        private bool IsFormValid()
        {
            return IsLoginValid(false)
                   && IsUrlValide(false)
                   && IsNameValid(false)
                   //Si le panel de saisi du mot de passe alors on vérifie la validité du mot de passe.
                   //Sinon on vérifie si un mot de passe a été généré. 
                   && (panelSaisie.Enabled
                       ? IsPasswordValid(false) && IsSecondPasswordValide(false)
                       : !String.IsNullOrEmpty(lblPwdGenerated.Text));
        }
    }
}