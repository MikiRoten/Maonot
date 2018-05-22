﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Maonot.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "תעודת זהות")]
        [RegularExpression(@"^\d{9}$",ErrorMessage = "Please Enter Correct ID")]
        public int StundetId { get; set; }
        [Required]
        [Display(Name = "שם פרטי")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "סיסמא")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "דואר אלקטרוני")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }
        
        [Display(Name = "מספר דירה")]
        public int ApartmentNum { get; set; }
        
        [Display(Name = "מספר חדר")]
        public RoomNum? Room { get; set; }
    }
}
