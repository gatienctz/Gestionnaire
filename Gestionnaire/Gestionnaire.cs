using System;
using System.IO;
using System.Windows.Forms;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class Gestionnaire : Form
    {
        private Profil _user;
        private Entries _entries;
        
        public Gestionnaire(Profil p)
        {
            InitializeComponent();
            _user = p;
            _entries = MyUtils.ExtractEntries(Path.Combine(Entry.folderName,_user.PathFileEntries));
            dataGridView1.DataSource = _entries.Entry;
        }

        private void tsbtn_deleteEntry_Click(object sender, EventArgs e)
        {
            //TODO Suppression d'un ou des entrées sélectionnées.
            Dialog_DelEntry dde = new Dialog_DelEntry();
            DialogResult res = dde.ShowDialog();
            //affichage de la boîte de dialogue et attente...
            if (res== DialogResult.OK)
            {
                
            }

        }

        private void tsbtn_addEntry_Click(object sender, EventArgs e)
        {
            Dialog_AddEntry dae = new Dialog_AddEntry();
            DialogResult res = dae.ShowDialog();
            if (res == DialogResult.OK)
            {
                string name = dae.tbName.Text;
                string username = dae.tbUsername.Text;
                string url = dae.tbUrl.Text;
                string password = dae.rbtnGenerate.Checked ? dae.lblPwdGenerated.Text : dae.tbPwd.Text;
                Entry newEntry = new Entry(name, username, url, password);
                _entries.AddEntry(newEntry);
                MyUtils.AddEntry(Path.Combine(Entry.folderName, _user.PathFileEntries), newEntry);
                dataGridView1.Rows.Add(newEntry);
            }
        }
    }
}