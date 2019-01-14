using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Everis.Models
{
    public class SpreadsheetEntry
    {       
        public int ID { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public DateTime ReferenceDate { get; set; }  
        
        [Display(Name = "Título")]
        [StringLength(255)]
        public string Title { get; set; }
    }
}
