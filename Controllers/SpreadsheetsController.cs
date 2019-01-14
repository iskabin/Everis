using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Everis.Data;
using Everis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Everis.Controllers
{
    public class SpreadsheetsController : Controller
    {
        private ProductsContext _context;

        public SpreadsheetsController(ProductsContext context)
        {
            _context = context;
        }

        [Route("/Spreadsheets")]
        public IActionResult Index()
        {
            var spreadsheets = _context.SpreadsheetEntries.ToList();

            return View(spreadsheets);
        }

        [Route("/Spreadsheets/{id}")]
        public IActionResult Details(int id)
        {
            var spreadsheet = _context.SpreadsheetEntries.Where( s => s.ID == id).SingleOrDefault();

            return View(spreadsheet);
        }

        [HttpPost]
        [Route("/Spreadsheets/SetTitle")]
        public IActionResult SetTitle(string title, int id)
        {
            SpreadsheetEntry spreadsheet = _context.SpreadsheetEntries.Where(s => s.ID == id).SingleOrDefault();

            spreadsheet.Title = title;

            _context.SpreadsheetEntries.Update(spreadsheet);

            _context.SaveChanges();

            return View("Details", spreadsheet);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            _context.Dispose();
        }
    }
}