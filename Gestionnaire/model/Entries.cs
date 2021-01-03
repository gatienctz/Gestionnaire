using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace Gestionnaire.model
{
    public class Entries
    {
        private BindingList<Entry> _entry;

        [XmlElement("Entry")]
        public BindingList<Entry> Entry
        {
            get => _entry;
            set => _entry = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Entries()
        {
            Entry = new BindingList<Entry>();
        }

        public void AddEntry(XmlDocument xmlDoc, Entry e)
        {
            Entry.Add(e);
            MyUtils.AddEntryToXmlDocument(xmlDoc, e);
        }

        public bool DeleteEntry(XmlDocument xmlDoc, Entry e)
        {
            return Entry.Remove(e)
                   && MyUtils.DeleteEntryToXmlDocument(xmlDoc, e);
        }

        public bool UpdateEntry(XmlDocument xmlDoc, Entry e)
        {
            e.Name = "Ceci est un test de modification";
            return true;
        }
        
    }
}