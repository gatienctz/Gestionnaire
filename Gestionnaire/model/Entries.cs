using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public void AddEntry(Entry e)
        {
            Entry.Add(e);
        }

        public bool DeleteEntry(Entry e)
        {
            return Entry.Remove(e);
        }
    }
}