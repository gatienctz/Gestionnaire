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
            this.lblEntryToDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voulez-vous vraiment supprimer cette entrée ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btConfirmer
            // 
            this.btConfirmer.BackColor = System.Drawing.Color.DarkGreen;
            this.btConfirmer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btConfirmer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btConfirmer.Location = new System.Drawing.Point(25, 313);
            this.btConfirmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConfirmer.Name = "btConfirmer";
            this.btConfirmer.Size = new System.Drawing.Size(148, 42);
            this.btConfirmer.TabIndex = 1;
            this.btConfirmer.Text = "Confirmer";
            this.btConfirmer.UseVisualStyleBackColor = false;
            this.btConfirmer.Click += new System.EventHandler(this.btConfirmer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.Red;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAnnuler.Location = new System.Drawing.Point(336, 313);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(139, 42);
            this.btAnnuler.TabIndex = 2;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // lblEntryToDelete
            // 
            this.lblEntryToDelete.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEntryToDelete.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEntryToDelete.Location = new System.Drawing.Point(84, 85);
            this.lblEntryToDelete.Name = "lblEntryToDelete";
            this.lblEntryToDelete.Size = new System.Drawing.Size(323, 207);
            this.lblEntryToDelete.TabIndex = 3;
            this.lblEntryToDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dialog_DelEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(487, 366);
            this.Controls.Add(this.lblEntryToDelete);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btConfirmer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dialog_DelEntry";
            this.Text = "Supprimer l\'entrée";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblEntryToDelete;

        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btConfirmer;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}