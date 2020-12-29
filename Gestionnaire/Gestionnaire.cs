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
        private static int id = 2;
        public Gestionnaire(Profil p)
        {
            InitializeComponent();
            _user = p;
            _entries = MyUtils.ExtractEntries(Path.Combine(Entry.folderName,_user.PathFileEntries));
            dataGridView1.DataSource = _entries;
        }

        private void tsbtn_deleteEntry_Click(object sender, EventArgs e)
        {
            
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
                Entry newEntry = new Entry(name, username, url, password, id++);
                Console.WriteLine("Add entry");
                _entries.AddEntry(newEntry);
            }
        }
    }
}