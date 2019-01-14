using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Everis.Models
{
    public class Inconsistency
    {
        public int ID { get; set; }

        [Required]
        public SpreadsheetEntry SpreadsheetID { get; set; }

        [Display(Name = "Coluna")]
        public int? Collumn { get; set; }

        [Display(Name = "Linha")]
        public int? Row { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public InconsistencyType Type { get; set; }

        [StringLength(255)]
        [Display(Name = "Valor lido")]
        public string CellValue { get; set; }

        [Display(Name = "Atributo")]
        public InconsistentAttribute Attribute { get; set; }
    }

    public enum InconsistencyType
    {
        MissingAttributeOnSheet,
        WrongDataTypeOnCell,
        MissingDataOnCell
    }

    public enum InconsistentAttribute
    {
        Company,
        Code,
        Name,
        Income,
        Outcome,
        Stock,
        Date
    }
}
