using System;
using System.IO;
using System.Net;
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
                        MyUtils.SaveXmlDocToFile(Path.Combine(Entry.folderName, _user.PathFileEntries), _dbXmlDoc);
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
                MyUtils.SaveXmlDocToFile(Path.Combine(Entry.folderName,_user.PathFileEntries), _dbXmlDoc);
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
                        MyUtils.SaveXmlDocToFile(Path.Combine(Entry.folderName,_user.PathFileEntries), _dbXmlDoc);
                    }
                }
                
            }
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
            catch (System.ComponentModel.Win32Exception noBrowser)
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
    }
}