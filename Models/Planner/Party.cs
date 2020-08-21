using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using login_register.Models;

namespace exam1_csharp.Models
{
    public class Party
    {
        [Key]
        public int PartyId{get;set;}
        [Required]
        public int OwnerId{get;set;}
        public User Owner{get;set;}
        
        [Required]
        public string Title{get;set;}
        [Required]
        public string Description{get;set;}


        [DataType(DataType.Time)]
        public DateTime Time{get;set;}
        public int Duration{get;set;}
        public string DurationUnit{get;set;}
        [Required]
        [IsFutureDate]
        [DataType(DataType.Date)]
        public DateTime Date{get;set;}
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;

        public List<RSVP> RSVPs {get;set;}
    }
}