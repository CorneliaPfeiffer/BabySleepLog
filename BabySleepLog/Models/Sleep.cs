using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BabySleepLog.Models
{
    public class Sleep
    {        
        public enum SleepType
        {
            Night = 1,
            Morning = 2,
            Lunch = 3,
            Afternoon = 4,
            Irregular = 5
        }
        public Sleep()
        { }
      
        public Sleep(SleepType sleepType, string name = null)
        {
            SleepId = (int)sleepType;            
            Name = name ?? sleepType.ToString();
        }
               
        public int SleepId { get; set; }       
        public string Name { get; set; }
    }
}