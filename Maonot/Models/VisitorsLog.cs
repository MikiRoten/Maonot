using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Maonot.Models

{
    public enum RoomNum
    {
        אחת, שתיים,שלוש,ארבע
    }
    public class VisitorsLog
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EnteryDate { get; set; }
        [Required]
        public string VistorName { get; set; }
        [Required]
        public int VisitorID { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime ExitDate { get; set; }
        [Required]
        public int ApartmentNum { get; set; }
        [Required]
        public RoomNum? Room{ get; set; }
        public Boolean Signature {
            
            set
            {
                Signature = false;
            }
            get
            {
                return Signature;
            }
        }






    }
}
