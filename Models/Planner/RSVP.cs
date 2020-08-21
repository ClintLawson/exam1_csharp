using System;
using System.ComponentModel.DataAnnotations;
using login_register.Models;

namespace exam1_csharp.Models
{
    public class RSVP
    {
        [Key]
        public int RSVPId{get;set;}
        public int PartyId{get;set;}
        public Party Party{get;set;}
        public int UserId{get;set;}
        public User User{get;set;}
    }
}