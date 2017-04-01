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
      
        public Sleep(SleepType sleepType, string name = null)
        {
            Id = (int)sleepType;            
            Name = name ?? sleepType.ToString();
        }
               
        public int Id { get; set; }       
        public string Name { get; set; }
    }
}