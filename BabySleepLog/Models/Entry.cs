using System;
using System.ComponentModel.DataAnnotations;

namespace BabySleepLog.Models
{
    public class Entry
    {
        public enum SleepLevel
        {
            Shallow,
            Heavy
        }
     
        public Entry()
        { }        
        
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        [Display(Name = "Sleep")]
        public int SleepId { get; set; }

        public Sleep Sleep { get; set; }
       
        public double Duration { get; set; }
        
        public SleepLevel Level { get; set; }
       
        public bool Exclude { get; set; }

        [MaxLength(200, ErrorMessage = "The Notes field cannot be longer than 200 characters.")]
        public string Notes { get; set; }
    }
}