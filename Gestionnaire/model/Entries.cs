using System.Collections.Generic;
using System.ComponentModel;

namespace Gestionnaire.model
{
    public class Entries
    {
        public BindingList<Entry> MyEntries;
        public Entries()
        {
            MyEntries = new BindingList<Entry>();
        }

        public void AddEntry(Entry e)
        {
            MyEntries.Add(e);
        }

        public bool DeleteEntry(Entry e)
        {
            return MyEntries.Remove(e);
        }
    }
}