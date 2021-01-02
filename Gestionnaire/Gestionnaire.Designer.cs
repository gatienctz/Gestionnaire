﻿using System.ComponentModel;

namespace Gestionnaire
{
    partial class Gestionnaire
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Internet");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Cloud");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("eMail");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Mon coffre fort", new System.Windows.Forms.TreeNode[] {treeNode1, treeNode2, treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionnaire));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_addEntry = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_deleteEntry = new System.Windows.Forms.ToolStripButton();
            this.rechercheParURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.PapayaWhip;
            this.treeView1.Location = new System.Drawing.Point(9, 59);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nœud3";
            treeNode1.Text = "Internet";
            treeNode2.Name = "Nœud4";
            treeNode2.Text = "Cloud";
            treeNode3.Name = "Nœud5";
            treeNode3.Text = "eMail";
            treeNode4.Name = "node_root";
            treeNode4.Text = "Mon coffre fort";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {treeNode4});
            this.treeView1.Size = new System.Drawing.Size(141, 297);
            this.treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.col_Title, this.col_Username, this.col_URL, this.col_password});
            this.dataGridView1.Location = new System.Drawing.Point(154, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(437, 297);
            this.dataGridView1.TabIndex = 1;
            // 
            // col_Title
            // 
            this.col_Title.DataPropertyName = "Name";
            this.col_Title.HeaderText = "Titre";
            this.col_Title.Name = "col_Title";
            this.col_Title.ReadOnly = true;
            // 
            // col_Username
            // 
            this.col_Username.DataPropertyName = "UserName";
            this.col_Username.FillWeight = 150F;
            this.col_Username.HeaderText = "Nom d\'utilisateur";
            this.col_Username.Name = "col_Username";
            this.col_Username.ReadOnly = true;
            // 
            // col_URL
            // 
            this.col_URL.DataPropertyName = "Url";
            this.col_URL.HeaderText = "URL";
            this.col_URL.Name = "col_URL";
            this.col_URL.ReadOnly = true;
            // 
            // col_password
            // 
            this.col_password.DataPropertyName = "Password";
            this.col_password.HeaderText = "Mot de passe";
            this.col_password.Name = "col_password";
            this.col_password.ReadOnly = true;
            this.col_password.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.rechercheParURLToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsbtn_addEntry, this.tsbtn_deleteEntry});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_addEntry
            // 
            this.tsbtn_addEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_addEntry.Image = ((System.Drawing.Image) (resources.GetObject("tsbtn_addEntry.Image")));
            this.tsbtn_addEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_addEntry.Name = "tsbtn_addEntry";
            this.tsbtn_addEntry.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_addEntry.Text = "toolStripButton1";
            this.tsbtn_addEntry.Click += new System.EventHandler(this.tsbtn_addEntry_Click);
            // 
            // tsbtn_deleteEntry
            // 
            this.tsbtn_deleteEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_deleteEntry.Image = ((System.Drawing.Image) (resources.GetObject("tsbtn_deleteEntry.Image")));
            this.tsbtn_deleteEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_deleteEntry.Name = "tsbtn_deleteEntry";
            this.tsbtn_deleteEntry.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_deleteEntry.Text = "toolStripButton2";
            this.tsbtn_deleteEntry.Click += new System.EventHandler(this.tsbtn_deleteEntry_Click);
            // 
            // rechercheParURLToolStripMenuItem
            // 
            this.rechercheParURLToolStripMenuItem.Name = "rechercheParURLToolStripMenuItem";
            this.rechercheParURLToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.rechercheParURLToolStripMenuItem.Text = "Recherche par URL";
            this.rechercheParURLToolStripMenuItem.Click += new System.EventHandler(this.rechercheParURLToolStripMenuItem_Click);
            // 
            // Gestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Gestionnaire";
            this.Text = "Gestionnaire";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem rechercheParURLToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton tsbtn_addEntry;
        private System.Windows.Forms.ToolStripButton tsbtn_deleteEntry;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Title;
        private System.Windows.Forms.DataGridViewLinkColumn col_URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Username;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;

        #endregion
    }
}