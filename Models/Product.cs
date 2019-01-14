using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Everis.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "O campo Empresa é obrigatório!")]
        [StringLength(255)]
        [Display(Name = "Empresa")]
        public string Company { get; set; }

        [Required(ErrorMessage = "O campo Código é obrigatório!")]
        [Display(Name = "Código")]
        [ProductCodeValidation]
        [Range(1, int.MaxValue, ErrorMessage = "O código deve ser um inteiro positivo!")]
        public int Code { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Entrada")]
        [Range(1, int.MaxValue, ErrorMessage = "A entrada deve ser um inteiro positivo!")]
        public int? Income { get; set; }

        [Display(Name = "Saída")]
        [Range(1, int.MaxValue, ErrorMessage = "A saída deve ser um inteiro positivo!")]
        public int? Outcome { get; set; }

        [Required(ErrorMessage = "O campo Estoque é obrigatório!")]
        [Display(Name = "Estoque")]
        [Range(0, int.MaxValue, ErrorMessage = "A estoque deve ser um inteiro positivo!")]
        public int Stock { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public DateTime LastEdit { get; set; }

        public AddType EditType { get; set; }

        [Required]
        public AddType AddType { get; set; }

        public SpreadsheetEntry SpreadsheetId { get; set; }

        public Product() { }
    }

    
    public enum AddType
    {
        Excel,
        Formulário,
        Banco
    }
}
