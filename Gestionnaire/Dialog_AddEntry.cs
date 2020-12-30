using System;
using System.Linq;
using System.Windows.Forms;

namespace Gestionnaire
{
    public partial class Dialog_AddEntry : Form
    {
        public Dialog_AddEntry()
        {
            InitializeComponent();
        }

        private void rbtnGenerate_CheckedChanged(object sender, EventArgs e)
        {
            panelGenerator.Enabled = rbtnGenerate.Checked;
        }

        private void rbtnSaisie_CheckedChanged(object sender, EventArgs e)
        {
            panelSaisie.Enabled = rbtnSaisie.Checked;
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
        }
    }
}