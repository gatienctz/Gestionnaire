using System.ComponentModel;

namespace Gestionnaire
{
    partial class Dialog_DelEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.btConfirmer = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voulez-vous vraiment supprimer la selection?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btConfirmer
            // 
            this.btConfirmer.Location = new System.Drawing.Point(120, 165);
            this.btConfirmer.Name = "btConfirmer";
            this.btConfirmer.Size = new System.Drawing.Size(166, 52);
            this.btConfirmer.TabIndex = 1;
            this.btConfirmer.Text = "Confirmer";
            this.btConfirmer.UseVisualStyleBackColor = true;
            this.btConfirmer.Click += new System.EventHandler(this.btConfirmer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(470, 165);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(156, 52);
            this.btAnnuler.TabIndex = 2;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // Dialog_DelEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 275);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btConfirmer);
            this.Controls.Add(this.label1);
            this.Name = "Dialog_DelEntry";
            this.Text = "Dialog_DelEntry";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btConfirmer;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}