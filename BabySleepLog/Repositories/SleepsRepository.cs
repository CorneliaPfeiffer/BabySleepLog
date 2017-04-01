using BabySleepLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BabySleepLog.Repositories
{
    public class SleepsRepository
    {
        DataModel db = new DataModel();
        public IEnumerable<Sleep> GetSleeps()
        {
            return db.Sleeps.OrderBy(a => a.Name).ToList();
        }
    }
}