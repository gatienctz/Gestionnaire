using System.ComponentModel;

namespace Gestionnaire
{
    partial class Dialog_AddEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelSaisie = new System.Windows.Forms.Panel();
            this.tbPwd_second = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGenerator = new System.Windows.Forms.Panel();
            this.lblPwdGenerated = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBSpecialChar = new System.Windows.Forms.GroupBox();
            this.checkBDeuxPoints = new System.Windows.Forms.CheckBox();
            this.checkBDollar = new System.Windows.Forms.CheckBox();
            this.checkInterro = new System.Windows.Forms.CheckBox();
            this.checkBPourcent = new System.Windows.Forms.CheckBox();
            this.checkBVirgule = new System.Windows.Forms.CheckBox();
            this.checkBCircon = new System.Windows.Forms.CheckBox();
            this.checkBPoint = new System.Windows.Forms.CheckBox();
            this.checkBHashTag = new System.Windows.Forms.CheckBox();
            this.checkBMulti = new System.Windows.Forms.CheckBox();
            this.checkBPointVir = new System.Windows.Forms.CheckBox();
            this.checkBArobaze = new System.Windows.Forms.CheckBox();
            this.checkBExclamation = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLengthPwd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackbarLengthPwd = new System.Windows.Forms.TrackBar();
            this.checkDigit = new System.Windows.Forms.CheckBox();
            this.checkMaj = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.rbtnSaisie = new System.Windows.Forms.RadioButton();
            this.rbtnGenerate = new System.Windows.Forms.RadioButton();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panelSaisie.SuspendLayout();
            this.panelGenerator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBSpecialChar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackbarLengthPwd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(12, 653);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 29);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ajouter";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(375, 653);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelSaisie);
            this.groupBox1.Controls.Add(this.panelGenerator);
            this.groupBox1.Controls.Add(this.rbtnSaisie);
            this.groupBox1.Controls.Add(this.rbtnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 516);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mot de passe";
            // 
            // panelSaisie
            // 
            this.panelSaisie.Controls.Add(this.tbPwd_second);
            this.panelSaisie.Controls.Add(this.label5);
            this.panelSaisie.Controls.Add(this.tbPwd);
            this.panelSaisie.Controls.Add(this.label4);
            this.panelSaisie.Location = new System.Drawing.Point(4, 409);
            this.panelSaisie.Name = "panelSaisie";
            this.panelSaisie.Size = new System.Drawing.Size(438, 101);
            this.panelSaisie.TabIndex = 3;
            // 
            // tbPwd_second
            // 
            this.tbPwd_second.Location = new System.Drawing.Point(186, 63);
            this.tbPwd_second.Name = "tbPwd_second";
            this.tbPwd_second.Size = new System.Drawing.Size(216, 22);
            this.tbPwd_second.TabIndex = 5;
            this.tbPwd_second.UseSystemPasswordChar = true;
            this.tbPwd_second.TextChanged += new System.EventHandler(this.tbPwd_second_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Répéter le mot de passe : ";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(186, 12);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(216, 22);
            this.tbPwd.TabIndex = 4;
            this.tbPwd.UseSystemPasswordChar = true;
            this.tbPwd.TextChanged += new System.EventHandler(this.tbPwd_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mot de passe : ";
            // 
            // panelGenerator
            // 
            this.panelGenerator.Controls.Add(this.lblPwdGenerated);
            this.panelGenerator.Controls.Add(this.btnGenerate);
            this.panelGenerator.Controls.Add(this.groupBox2);
            this.panelGenerator.Enabled = false;
            this.panelGenerator.Location = new System.Drawing.Point(4, 51);
            this.panelGenerator.Name = "panelGenerator";
            this.panelGenerator.Size = new System.Drawing.Size(435, 322);
            this.panelGenerator.TabIndex = 2;
            // 
            // lblPwdGenerated
            // 
            this.lblPwdGenerated.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPwdGenerated.Location = new System.Drawing.Point(25, 24);
            this.lblPwdGenerated.Name = "lblPwdGenerated";
            this.lblPwdGenerated.Size = new System.Drawing.Size(391, 23);
            this.lblPwdGenerated.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(89, 61);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(263, 26);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Générer un mot de passe";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBSpecialChar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblLengthPwd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.trackbarLengthPwd);
            this.groupBox2.Controls.Add(this.checkDigit);
            this.groupBox2.Controls.Add(this.checkMaj);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Location = new System.Drawing.Point(3, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 226);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // groupBSpecialChar
            // 
            this.groupBSpecialChar.Controls.Add(this.checkBDeuxPoints);
            this.groupBSpecialChar.Controls.Add(this.checkBDollar);
            this.groupBSpecialChar.Controls.Add(this.checkInterro);
            this.groupBSpecialChar.Controls.Add(this.checkBPourcent);
            this.groupBSpecialChar.Controls.Add(this.checkBVirgule);
            this.groupBSpecialChar.Controls.Add(this.checkBCircon);
            this.groupBSpecialChar.Controls.Add(this.checkBPoint);
            this.groupBSpecialChar.Controls.Add(this.checkBHashTag);
            this.groupBSpecialChar.Controls.Add(this.checkBMulti);
            this.groupBSpecialChar.Controls.Add(this.checkBPointVir);
            this.groupBSpecialChar.Controls.Add(this.checkBArobaze);
            this.groupBSpecialChar.Controls.Add(this.checkBExclamation);
            this.groupBSpecialChar.Location = new System.Drawing.Point(86, 98);
            this.groupBSpecialChar.Name = "groupBSpecialChar";
            this.groupBSpecialChar.Size = new System.Drawing.Size(197, 122);
            this.groupBSpecialChar.TabIndex = 26;
            this.groupBSpecialChar.TabStop = false;
            this.groupBSpecialChar.Text = "Charactères spéciaux";
            // 
            // checkBDeuxPoints
            // 
            this.checkBDeuxPoints.Checked = true;
            this.checkBDeuxPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBDeuxPoints.Location = new System.Drawing.Point(58, 51);
            this.checkBDeuxPoints.Name = "checkBDeuxPoints";
            this.checkBDeuxPoints.Size = new System.Drawing.Size(47, 24);
            this.checkBDeuxPoints.TabIndex = 20;
            this.checkBDeuxPoints.Text = ":";
            this.checkBDeuxPoints.UseVisualStyleBackColor = true;
            // 
            // checkBDollar
            // 
            this.checkBDollar.Checked = true;
            this.checkBDollar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBDollar.Location = new System.Drawing.Point(152, 81);
            this.checkBDollar.Name = "checkBDollar";
            this.checkBDollar.Size = new System.Drawing.Size(40, 24);
            this.checkBDollar.TabIndex = 21;
            this.checkBDollar.Text = "$";
            this.checkBDollar.UseVisualStyleBackColor = true;
            // 
            // checkInterro
            // 
            this.checkInterro.Location = new System.Drawing.Point(153, 21);
            this.checkInterro.Name = "checkInterro";
            this.checkInterro.Size = new System.Drawing.Size(39, 24);
            this.checkInterro.TabIndex = 25;
            this.checkInterro.Text = "?";
            this.checkInterro.UseVisualStyleBackColor = true;
            // 
            // checkBPourcent
            // 
            this.checkBPourcent.Checked = true;
            this.checkBPourcent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBPourcent.Location = new System.Drawing.Point(58, 81);
            this.checkBPourcent.Name = "checkBPourcent";
            this.checkBPourcent.Size = new System.Drawing.Size(44, 24);
            this.checkBPourcent.TabIndex = 19;
            this.checkBPourcent.Text = "%";
            this.checkBPourcent.UseVisualStyleBackColor = true;
            // 
            // checkBVirgule
            // 
            this.checkBVirgule.Checked = true;
            this.checkBVirgule.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBVirgule.Location = new System.Drawing.Point(108, 81);
            this.checkBVirgule.Name = "checkBVirgule";
            this.checkBVirgule.Size = new System.Drawing.Size(44, 24);
            this.checkBVirgule.TabIndex = 24;
            this.checkBVirgule.Text = ",";
            this.checkBVirgule.UseVisualStyleBackColor = true;
            // 
            // checkBCircon
            // 
            this.checkBCircon.Location = new System.Drawing.Point(58, 21);
            this.checkBCircon.Name = "checkBCircon";
            this.checkBCircon.Size = new System.Drawing.Size(48, 24);
            this.checkBCircon.TabIndex = 18;
            this.checkBCircon.Text = "^";
            this.checkBCircon.UseVisualStyleBackColor = true;
            // 
            // checkBPoint
            // 
            this.checkBPoint.Checked = true;
            this.checkBPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBPoint.Location = new System.Drawing.Point(108, 51);
            this.checkBPoint.Name = "checkBPoint";
            this.checkBPoint.Size = new System.Drawing.Size(44, 24);
            this.checkBPoint.TabIndex = 23;
            this.checkBPoint.Text = ".";
            this.checkBPoint.UseVisualStyleBackColor = true;
            // 
            // checkBHashTag
            // 
            this.checkBHashTag.Checked = true;
            this.checkBHashTag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBHashTag.Location = new System.Drawing.Point(5, 21);
            this.checkBHashTag.Name = "checkBHashTag";
            this.checkBHashTag.Size = new System.Drawing.Size(47, 24);
            this.checkBHashTag.TabIndex = 17;
            this.checkBHashTag.Text = "#";
            this.checkBHashTag.UseVisualStyleBackColor = true;
            // 
            // checkBMulti
            // 
            this.checkBMulti.Location = new System.Drawing.Point(108, 21);
            this.checkBMulti.Name = "checkBMulti";
            this.checkBMulti.Size = new System.Drawing.Size(44, 24);
            this.checkBMulti.TabIndex = 22;
            this.checkBMulti.Text = "*";
            this.checkBMulti.UseVisualStyleBackColor = true;
            // 
            // checkBPointVir
            // 
            this.checkBPointVir.Checked = true;
            this.checkBPointVir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBPointVir.Location = new System.Drawing.Point(4, 81);
            this.checkBPointVir.Name = "checkBPointVir";
            this.checkBPointVir.Size = new System.Drawing.Size(48, 24);
            this.checkBPointVir.TabIndex = 15;
            this.checkBPointVir.Text = ";";
            this.checkBPointVir.UseVisualStyleBackColor = true;
            // 
            // checkBArobaze
            // 
            this.checkBArobaze.Location = new System.Drawing.Point(5, 51);
            this.checkBArobaze.Name = "checkBArobaze";
            this.checkBArobaze.Size = new System.Drawing.Size(48, 24);
            this.checkBArobaze.TabIndex = 14;
            this.checkBArobaze.Text = "@";
            this.checkBArobaze.UseVisualStyleBackColor = true;
            // 
            // checkBExclamation
            // 
            this.checkBExclamation.Checked = true;
            this.checkBExclamation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBExclamation.Location = new System.Drawing.Point(153, 51);
            this.checkBExclamation.Name = "checkBExclamation";
            this.checkBExclamation.Size = new System.Drawing.Size(39, 24);
            this.checkBExclamation.TabIndex = 1;
            this.checkBExclamation.Text = "!";
            this.checkBExclamation.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(305, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "40";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(22, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "6";
            // 
            // lblLengthPwd
            // 
            this.lblLengthPwd.Location = new System.Drawing.Point(174, 25);
            this.lblLengthPwd.Name = "lblLengthPwd";
            this.lblLengthPwd.Size = new System.Drawing.Size(63, 23);
            this.lblLengthPwd.TabIndex = 7;
            this.lblLengthPwd.Text = "6";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Taille du mot de passe :";
            // 
            // trackbarLengthPwd
            // 
            this.trackbarLengthPwd.BackColor = System.Drawing.SystemColors.Control;
            this.trackbarLengthPwd.Location = new System.Drawing.Point(12, 51);
            this.trackbarLengthPwd.Maximum = 40;
            this.trackbarLengthPwd.Minimum = 6;
            this.trackbarLengthPwd.Name = "trackbarLengthPwd";
            this.trackbarLengthPwd.Size = new System.Drawing.Size(325, 56);
            this.trackbarLengthPwd.TabIndex = 4;
            this.trackbarLengthPwd.Value = 6;
            this.trackbarLengthPwd.Scroll += new System.EventHandler(this.trackbarLengthPwd_Scroll);
            // 
            // checkDigit
            // 
            this.checkDigit.Location = new System.Drawing.Point(12, 179);
            this.checkDigit.Name = "checkDigit";
            this.checkDigit.Size = new System.Drawing.Size(68, 24);
            this.checkDigit.TabIndex = 3;
            this.checkDigit.Text = "0-9";
            this.checkDigit.UseVisualStyleBackColor = true;
            // 
            // checkMaj
            // 
            this.checkMaj.Location = new System.Drawing.Point(12, 149);
            this.checkMaj.Name = "checkMaj";
            this.checkMaj.Size = new System.Drawing.Size(67, 24);
            this.checkMaj.TabIndex = 0;
            this.checkMaj.Text = "A-Z";
            this.checkMaj.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(12, 119);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "a-z";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // rbtnSaisie
            // 
            this.rbtnSaisie.Checked = true;
            this.rbtnSaisie.Location = new System.Drawing.Point(6, 379);
            this.rbtnSaisie.Name = "rbtnSaisie";
            this.rbtnSaisie.Size = new System.Drawing.Size(210, 24);
            this.rbtnSaisie.TabIndex = 1;
            this.rbtnSaisie.TabStop = true;
            this.rbtnSaisie.Text = "Saisir un mot de passe";
            this.rbtnSaisie.UseVisualStyleBackColor = true;
            this.rbtnSaisie.CheckedChanged += new System.EventHandler(this.rbtnSaisie_CheckedChanged);
            // 
            // rbtnGenerate
            // 
            this.rbtnGenerate.Location = new System.Drawing.Point(6, 21);
            this.rbtnGenerate.Name = "rbtnGenerate";
            this.rbtnGenerate.Size = new System.Drawing.Size(231, 24);
            this.rbtnGenerate.TabIndex = 0;
            this.rbtnGenerate.Text = "Générer un mot de passe";
            this.rbtnGenerate.UseVisualStyleBackColor = true;
            this.rbtnGenerate.CheckedChanged += new System.EventHandler(this.rbtnGenerate_CheckedChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(210, 102);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(208, 22);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom d\'utilisateur : ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "URL du site : ";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(210, 69);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(208, 22);
            this.tbUrl.TabIndex = 2;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom de l\'enregistrement : ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(210, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(145, 22);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // Dialog_AddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 694);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "Dialog_AddEntry";
            this.Text = "Dialog_AddEntry";
            this.groupBox1.ResumeLayout(false);
            this.panelSaisie.ResumeLayout(false);
            this.panelSaisie.PerformLayout();
            this.panelGenerator.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBSpecialChar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.trackbarLengthPwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBSpecialChar;

        private System.Windows.Forms.CheckBox checkInterro;

        private System.Windows.Forms.CheckBox checkBArobaze;
        private System.Windows.Forms.CheckBox checkBCircon;
        private System.Windows.Forms.CheckBox checkBDeuxPoints;
        private System.Windows.Forms.CheckBox checkBDollar;
        private System.Windows.Forms.CheckBox checkBExclamation;
        private System.Windows.Forms.CheckBox checkBHashTag;
        private System.Windows.Forms.CheckBox checkBMulti;
        private System.Windows.Forms.CheckBox checkBPoint;
        private System.Windows.Forms.CheckBox checkBPointVir;
        private System.Windows.Forms.CheckBox checkBPourcent;
        private System.Windows.Forms.CheckBox checkBVirgule;

        public System.Windows.Forms.RadioButton rbtnGenerate;
        public System.Windows.Forms.RadioButton rbtnSaisie;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbUrl;
        public System.Windows.Forms.TextBox tbUsername;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;

        public System.Windows.Forms.Label lblPwdGenerated;

        private System.Windows.Forms.TextBox tbPwd_second;

        private System.Windows.Forms.CheckBox checkDigit;
        private System.Windows.Forms.CheckBox checkMaj;
        public System.Windows.Forms.TextBox tbPwd;

        private System.Windows.Forms.Button btnGenerate;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLengthPwd;

        private System.Windows.Forms.TrackBar trackbarLengthPwd;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Panel panelGenerator;
        private System.Windows.Forms.Panel panelSaisie;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        #endregion
    }
}