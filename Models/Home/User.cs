using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using exam1_csharp.Models;

namespace login_register.Models
{
    public class User
    {
        [Key]
        public int UserId{get;set;}
        [Required]
        [MinLength(2, ErrorMessage="Must be 2 or more characters")]
        [Display(Name = "Name")]
        public string Name{get;set;}

        [Required]
        [EmailAddress]
        public string Email{get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Must be 8 or more characters")]
        [PassTrick]
        public string Password{get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
        // [Required] //??? needed for initial validations??
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm{get;set;}

        public List<Party> Parties{get;set;}
        public List<RSVP> RSVPs {get;set;}
    }
}