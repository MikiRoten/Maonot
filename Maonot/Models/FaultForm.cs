using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Maonot.Models
{
    public class FaultForm
    {
        public int ID { get; set; }
        [Required]
        public int Apartment { get; set; }
        public int RoomNum { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
