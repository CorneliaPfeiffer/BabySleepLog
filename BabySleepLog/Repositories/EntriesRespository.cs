using BabySleepLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BabySleepLog.Repositories
{

    public class EntriesRespository
    {
        DataModel db = new DataModel();
        public IEnumerable<Entry> GetEntries()
        {
            IEnumerable<Entry> entries =
             db.Entries
                .OrderByDescending(e => e.Date)
                .ThenByDescending(e => e.EntryId)
                .ToList();

            return entries;
        }

        public Entry GetEntry(int id)
        {
            Entry entry = db.Entries
                .Where(e => e.EntryId == id)
                .SingleOrDefault();

            if (entry.Sleep == null)
            {
                entry.Sleep = db.Sleeps
                    .Where(a => a.SleepId == entry.SleepId)
                    .SingleOrDefault();
            }
            return entry;
        }

        public void AddEntry(Entry entry)
        {
            db.Entries.Add(entry);
        }
    }
}