using Everis.Data;
using Everis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Everis.ViewModels
{
    public class SpreadsheetsViewModel
    {
        private ProductsContext _context;

        public List<SpreadsheetEntry> Spreadsheets { get; set; }

        public List<Inconsistency> Inconsistencies { get; set; }

        public SpreadsheetsViewModel(ProductsContext context)
        {
            _context = context;

            Spreadsheets = _context.SpreadsheetEntries.ToList();

            Inconsistencies = _context.Inconsistencies.ToList();
        }
    }
}
