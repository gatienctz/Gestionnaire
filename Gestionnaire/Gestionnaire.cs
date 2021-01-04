using System;
using System.ComponentModel;
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
        private bool _saved = true;
        public Gestionnaire(Profil p)
        {
            InitializeComponent();
            _user = p;
            
            MyUtils.LoadFileToXmlDoc(Path.Combine(Entry.folderName,_user.PathFileEntries), _user.IdUsb, out _dbXmlDoc);
            _entries = MyUtils.ExtractEntries(_dbXmlDoc);
            
            dataGridView1.DataSource = _entries.Entry;
            _entries.Entry.ListChanged += ListChanged;
            tsbtnSave.Enabled = !_saved;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // If the column is the Artist column, check the
            // value.
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void ListChanged(object o, ListChangedEventArgs eArgs)
        {
            _saved = false;
            tsbtnSave.Enabled = !_saved;
        }
        
        private void tsbtn_deleteEntry_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Entry entryToDel = (Entry) dataGridView1.CurrentRow.DataBoundItem;
                    Dialog_DelEntry dde = new Dialog_DelEntry(entryToDel);
                    DialogResult res = dde.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        _entries.DeleteEntry(_dbXmlDoc, entryToDel);
                    }
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
                string url = dae.UrlString;
                string password = dae.rbtnGenerate.Checked ? dae.lblPwdGenerated.Text : dae.tbPwd.Text;
                Entry newEntry = new Entry(name, username, url, password);
                _entries.AddEntry(_dbXmlDoc, newEntry);
            }
        }

        private void rechercheParURLToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Dialog_URLResearch dde =new Dialog_URLResearch(_entries);
            dde.ShowDialog();
        }

        private void tsBtnUpdateEntry_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Entry entryToUpdate = (Entry) dataGridView1.CurrentRow.DataBoundItem;
                    Dialog_AddEntry dae = new Dialog_AddEntry();
                
                    dae.tbName.Text = entryToUpdate.Name;
                    dae.tbUrl.Text = entryToUpdate.Url;
                    dae.tbUsername.Text = entryToUpdate.UserName;
                    dae.tbPwd.Text = entryToUpdate.Password;
                    dae.tbPwd_second.Text = entryToUpdate.Password;
                    dae.btnOk.Text = "Modifier";

                    var dialogResult = dae.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        string name = dae.tbName.Text;
                        string username = dae.tbUsername.Text;
                        string url = dae.UrlString;
                        string password = dae.rbtnGenerate.Checked ? dae.lblPwdGenerated.Text : dae.tbPwd.Text;

                        _entries.UpdateEntry(_dbXmlDoc, entryToUpdate, name, username, url, password);
                        dataGridView1.Refresh();
                        _saved = false;
                        tsbtnSave.Enabled = !_saved;
                    }
                }
            }
        }

        private void SaveGestionnaire()
        {
            MyUtils.SaveXmlDocToFile(Path.Combine(Entry.folderName,_user.PathFileEntries), _dbXmlDoc, _user.IdUsb);
            _saved = true;
            tsbtnSave.Enabled = !_saved;
        }
        private static bool IsValidUri(string uri)
        {
            if (!Uri.IsWellFormedUriString(uri, UriKind.Absolute))
                return false;
            Uri tmp;
            if (!Uri.TryCreate(uri, UriKind.Absolute, out tmp))
                return false;
            return tmp.Scheme == Uri.UriSchemeHttp || tmp.Scheme == Uri.UriSchemeHttps;
        }

        private static bool OpenUri(string uri) 
        {
            if (!IsValidUri(uri))
                return false;
            
            try
            {
                Console.WriteLine(uri);
                System.Diagnostics.Process.Start(uri);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode==-2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message);
            }

            return true;
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                var uriString = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if(!String.IsNullOrEmpty(uriString))
                    if (IsValidUri(uriString))
                    {
                        OpenUri(uriString);
                    }
            }
        }

        private bool Quitter()
        {
            if (!_saved)
            {
                var resSave = MessageBox.Show(
                    "Des modifications n'ont pas été sauvegarder.\nVoulez-vous les sauvegarder avant de quitter ?",
                    "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (resSave)
                {
                    case DialogResult.Yes:
                    {
                        SaveGestionnaire();
                        return true;
                    }
                    case DialogResult.No:
                    {
                        return true;
                    }
                    case DialogResult.Cancel:
                    {
                        return false;
                    }
                }
            }
            var resQuit = MessageBox.Show("Voulez-vous vraiment quitter ?", "Quitter", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return resQuit == DialogResult.Yes;
        }
        private void Gestionnaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            var wantToLeave = Quitter();
            e.Cancel = !wantToLeave;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            SaveGestionnaire();
        }
    }
}