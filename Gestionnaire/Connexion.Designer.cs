using System.Windows.Forms;

namespace Gestionnaire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnecte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.linklCreateProfil = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnConnecte
            // 
            this.btnConnecte.Location = new System.Drawing.Point(133, 184);
            this.btnConnecte.Name = "btnConnecte";
            this.btnConnecte.Size = new System.Drawing.Size(94, 31);
            this.btnConnecte.TabIndex = 0;
            this.btnConnecte.Text = "Connexion";
            this.btnConnecte.UseVisualStyleBackColor = true;
            this.btnConnecte.Click += new System.EventHandler(this.btnConnecte_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(68, 58);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(228, 22);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(68, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe : ";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(68, 118);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(228, 22);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // linklCreateProfil
            // 
            this.linklCreateProfil.Location = new System.Drawing.Point(68, 143);
            this.linklCreateProfil.Name = "linklCreateProfil";
            this.linklCreateProfil.Size = new System.Drawing.Size(159, 23);
            this.linklCreateProfil.TabIndex = 5;
            this.linklCreateProfil.TabStop = true;
            this.linklCreateProfil.Text = "Créer un profil";
            this.linklCreateProfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklCreateProfil_LinkClicked);
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 258);
            this.Controls.Add(this.linklCreateProfil);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnecte);
            this.Name = "ConnexionForm";
            this.Text = "Connexion";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.LinkLabel linklCreateProfil;

        private System.Windows.Forms.Button btnConnecte;

        private System.Windows.Forms.TextBox tbPassword;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;

        #endregion
    }
}