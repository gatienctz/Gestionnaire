using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Gestionnaire.model;

namespace Gestionnaire
{
    public partial class Gestionnaire : Form
    {
        private Profil _user;
        private Entries _entries;
        private XmlDocument _dbXmlDoc;
        public Gestionnaire(Profil p)
        {
            InitializeComponent();
            _user = p;
            MyUtils.LoadFileToXmlDoc(Path.Combine(Entry.folderName,_user.PathFileEntries), out _dbXmlDoc);
            _entries = MyUtils.ExtractEntries(_dbXmlDoc);
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Entry entryToDel = (Entry) dataGridView1.CurrentRow.DataBoundItem;
                    _entries.DeleteEntry(_dbXmlDoc, entryToDel);
                    MyUtils.SaveXmlDocToFile(Path.Combine(Entry.folderName,_user.PathFileEntries), _dbXmlDoc);
                }
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
                _entries.AddEntry(_dbXmlDoc, newEntry);
                MyUtils.SaveXmlDocToFile(Path.Combine(Entry.folderName,_user.PathFileEntries), _dbXmlDoc);
            }
        }

        private void rechercheParURLToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Dialog_URLResearch dde =new Dialog_URLResearch(_entries);
            dde.ShowDialog();
        }
    }
}