using System.Collections.Generic;

namespace Gestionnaire.model
{
    public class ListOfEntry
    {
        public List<Entry> MyEntries;
        public ListOfEntry()
        {
            MyEntries = new List<Entry>();
        }

        public void AjouterUneEntree(Entry e)
        {
            MyEntries.Add(e);
        }
    }
}