using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Everis.Data;
using Everis.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Everis.Controllers
{
    public class InconsistenciesController : Controller
    {
        private ProductsContext _context;

        public InconsistenciesController(ProductsContext context)
        {
            _context = context;
        }

        [Route("/Inconsistencies")]
        public IActionResult Index()
        {
            return View(new SpreadsheetsViewModel(_context));
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            _context.Dispose();
        }
    }
}