using Everis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Everis.ViewModels
{
    public class SearchViewModel
    {
        //FILTERS
        [Display(Name = "Data de Entrada")]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Data de Entrada de")]
        public DateTime? IntervalStart { get; set; }

        [Display(Name = "Data de Entrada até")]
        public DateTime? IntervalEnd { get; set; }

        [Display(Name = "Empresa")]
        public string Company { get; set; }

        [Display(Name = "Código")]
        public int? Code { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Entrada")]
        public int? Income { get; set; }

        [Display(Name = "Entrada de")]
        public int? IncomeStart { get; set; }

        [Display(Name = "Entrada até")]
        public int? IncomeEnd { get; set; }

        [Display(Name = "Saída")]
        public int? Outcome { get; set; }

        [Display(Name = "Saída de")]
        public int? OutcomeStart { get; set; }

        [Display(Name = "Saída até")]
        public int? OutcomeEnd { get; set; }

        [Display(Name = "Estoque")]
        public int? Stock { get; set; }

        [Display(Name = "Estoque de")]
        public int? StockStart { get; set; }

        [Display(Name = "Estoque até")]
        public int? StockEnd { get; set; }

        [Display(Name = "Tipo de entrada")]
        public AddType? AddType { get; set; }

        [Display(Name = "Tipo de edição")]
        public AddType? EditType { get; set; }

        public List<AddType> _Types { get; set; }

        public SearchViewModel()
        {
            
        }
    }
}
