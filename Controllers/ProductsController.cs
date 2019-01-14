using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Everis.Data;
using Everis.Models;
using Everis.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Everis.Controllers
{
    public class ProductsController : Controller
    {
        private ProductsContext _context;

        private IHostingEnvironment _hostingEnvironment;

        public ProductsController(ProductsContext context, IHostingEnvironment hostingEnvironment)
        {          
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            _context.Dispose();
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();

            return View(products);
        }

        public IActionResult SearchResults(List<Product> products)
        {
            var _products = products;

            return View(_products);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveForm(Product product)
        {
            if (!ModelState.IsValid)
            {
                if (!(ModelState.ErrorCount == 1 && ModelState.Any(item => item.Key == "ID"))) {
                    return View("Form", product);
                }           
            }

            if (product.ID == 0)
            {
                product.AddType = AddType.Formulário;
                product.DateAdded = DateTime.Now;
                _context.Products.Add(product);
            }
            else
            {
                product.AddType = AddType.Formulário;
                product.LastEdit = DateTime.Now;
                _context.Products.Update(product);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Products");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Product product)
        {
            if (!ModelState.IsValid)
            {
                if (!(ModelState.ErrorCount == 1 && ModelState.Any(item => item.Key == "ID")))
                {
                    return View("New", product);
                }
            }

            if (product.ID == 0)
            {
                product.AddType = AddType.Formulário;
                product.DateAdded = DateTime.Now;
                _context.Products.Add(product);

                return RedirectToAction("Index", "Products");
            } 

            return View("New", product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(SearchViewModel search)
        {
            if (!ModelState.IsValid)
            {
                return View("SearchForm", search);
            }

            var productsQuery = _context.Products.AsQueryable();

            if(search.AddType != null)
            {
                productsQuery = productsQuery.Where(p => p.AddType == search.AddType);
            }

            if(search.Code != null)
            {
                productsQuery = productsQuery.Where(p => p.Code == search.Code);
            }

            if(search.Company != null)
            {
                productsQuery = productsQuery.Where(p => p.Company == search.Company);
            }

            if (search.DateAdded != null)
            {
                productsQuery = productsQuery.Where(p => p.DateAdded == search.DateAdded);
            }

            if (search.EditType != null)
            {
                productsQuery = productsQuery.Where(p => p.EditType == search.EditType);
            }

            if (search.Income != null)
            {
                productsQuery = productsQuery.Where(p => p.Income == search.Income);
            }

            if (search.Outcome != null)
            {
                productsQuery = productsQuery.Where(p => p.Outcome == search.Outcome);
            }

            if (search.Stock != null)
            {
                productsQuery = productsQuery.Where(p => p.Stock == search.Stock);
            }

            if (search.IntervalStart != null)
            {
                if (search.IntervalStart != null)
                {
                    productsQuery = productsQuery.Where(p => p.DateAdded >= search.IntervalStart && p.DateAdded <= search.IntervalStart);
                }
            }

            if (search.IncomeStart != null)
            {
                if(search.IncomeEnd != null)
                {
                    productsQuery = productsQuery.Where(p => p.Income >= search.IncomeStart && p.Income <= search.IncomeEnd);
                }                
            }

            if (search.OutcomeStart != null)
            {
                if (search.OutcomeEnd != null)
                {
                    productsQuery = productsQuery.Where(p => p.Outcome >= search.OutcomeStart && p.Outcome <= search.OutcomeEnd);
                }
            }

            if (search.StockStart != null)
            {
                if (search.StockEnd != null)
                {
                    productsQuery = productsQuery.Where(p => p.Stock >= search.StockStart && p.Stock <= search.StockEnd);
                }
            }

            var products = productsQuery.ToList();

            return View("SearchResults", products);
        }

        public IActionResult Form(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.ID == id);

            return View(product);
        }

        public IActionResult SearchForm(SearchViewModel search)
        {
            var _search = new SearchViewModel();

            _search._Types = new List<AddType>() { AddType.Excel, AddType.Formulário, AddType.Banco };

            if (search != null)
            {
                search._Types = new List<AddType>() { AddType.Excel, AddType.Formulário, AddType.Banco };
                return View(search);
            }
               
            return View(_search);
        }

        public IActionResult Spreadsheet()
        {
            return View();
        }

        [HttpDelete]
        [Route("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.ID == id);

            if (product == null)
                return StatusCode(404);

            _context.Products.Remove(product);

            _context.SaveChanges();

            return RedirectToAction("Index", "Products");
        }

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.ID == id);

            if (product == null)
                return StatusCode(404);

            return View(product);
        }

        [HttpPost]
        [Route("/importToDb")]
        public IActionResult ImportToDb([FromQuery] string title)
        {
            //TODO: colocar dentro de um foreach para ler varios arquivos de uma vez
            IFormFile file = Request.Form.Files[0];
            string folderName = "Upload";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);

            SpreadsheetEntry spreadsheet = new SpreadsheetEntry();
            spreadsheet.DateAdded = DateTime.Now;
            spreadsheet.Title = title;

            List<Product> products = new List<Product>();

            List<Inconsistency> inconsistencies = new List<Inconsistency>();

            StringBuilder sb = new StringBuilder();

            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            if (file.Length > 0)
            {
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                ISheet sheet;
                string fullPath = Path.Combine(newPath, file.FileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;
                    if (sFileExtension == ".xls")
                    {
                        HSSFWorkbook hssfwb = new HSSFWorkbook(stream); //This will read the Excel 97-2000 formats  
                        sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook  
                    }
                    else
                    {
                        XSSFWorkbook hssfwb = new XSSFWorkbook(stream); //This will read 2007 Excel format  
                        sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook   
                    }

                    ICell dateCell = sheet.GetRow(0).GetCell(1);

                    if (dateCell != null)
                    {
                        if(dateCell.CellType == CellType.Numeric)
                        {
                            if (DateUtil.IsCellDateFormatted(dateCell))
                            {
                                spreadsheet.ReferenceDate = dateCell.DateCellValue;
                                _context.SpreadsheetEntries.Add(spreadsheet);
                            }
                            else
                            {
                                return Content("<h2>Erro de formatação na planilha. Data não encontrada.</h2>");
                            }
                        }
                        else
                        {
                            return Content("<h2>Erro de formatação na planilha. Data não encontrada.</h2>");
                        }
                    }                        
                    else
                    {
                        return Content("<h2>Erro de formatação na planilha. Data não encontrada.</h2>");
                    }                    

                    IRow headerRow = sheet.GetRow(2); //Get Header Row
                    int cellCount = headerRow.LastCellNum;
                    sb.Append("<table class='table'><tr>");
                    for (int j = 0; j < cellCount; j++)
                    {                        
                        NPOI.SS.UserModel.ICell cell = headerRow.GetCell(j);
                        if (cell == null || string.IsNullOrWhiteSpace(cell.ToString())) continue;
                        sb.Append("<th>" + cell.ToString() + "</th>");
                    }
                    sb.Append("</tr>");
                    sb.AppendLine("<tr>");
                    int inconsistencyCount = inconsistencies.Count;
                    for (int i = (headerRow.RowNum + 1); i <= sheet.LastRowNum; i++) //Read Excel File
                    {                        
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue;
                        if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;
                        Product product = new Product();
                        product.SpreadsheetId = spreadsheet;
                        for (int j = row.FirstCellNum; j < cellCount; j++)
                        {
                            if (row.GetCell(j) != null)
                            {
                                switch (j)
                                {
                                    case 0:
                                        if (GetCellValue(row.GetCell(j)).ToString() == null || string.IsNullOrWhiteSpace(GetCellValue(row.GetCell(j)).ToString()))
                                        {
                                            inconsistencies.Add(new Inconsistency
                                            {
                                                SpreadsheetID = spreadsheet,
                                                Collumn = j,
                                                Row = i,
                                                Type = InconsistencyType.MissingDataOnCell,
                                                CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                Attribute = InconsistentAttribute.Company
                                            });
                                        }
                                        else
                                        {
                                            product.Company = GetCellValue(row.GetCell(j)).ToString();
                                        }
                                        break;

                                    case 1:
                                        if (row.GetCell(j).CellType == CellType.Numeric)
                                        {
                                            if (row.GetCell(j).NumericCellValue < 1 || string.IsNullOrWhiteSpace(row.GetCell(j).NumericCellValue.ToString()))
                                            {
                                                inconsistencies.Add(new Inconsistency
                                                {
                                                    SpreadsheetID = spreadsheet,
                                                    Collumn = j,
                                                    Row = i,
                                                    Type = row.GetCell(j).NumericCellValue < 1 ? InconsistencyType.WrongDataTypeOnCell : InconsistencyType.MissingDataOnCell,
                                                    CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                    Attribute = InconsistentAttribute.Code
                                                });
                                            }
                                            else
                                            {
                                                if (DateUtil.IsCellDateFormatted(row.GetCell(j)))
                                                {
                                                    inconsistencies.Add(new Inconsistency
                                                    {
                                                        SpreadsheetID = spreadsheet,
                                                        Collumn = j,
                                                        Row = i,
                                                        Type = InconsistencyType.WrongDataTypeOnCell,
                                                        CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                        Attribute = InconsistentAttribute.Code
                                                    });
                                                }
                                                else
                                                {
                                                    product.Code = Convert.ToInt32(row.GetCell(j).NumericCellValue);
                                                }                                                
                                            } 
                                        }
                                        else
                                        {
                                            inconsistencies.Add(new Inconsistency
                                            {
                                                SpreadsheetID = spreadsheet,
                                                Collumn = j,
                                                Row = i,
                                                Type = InconsistencyType.WrongDataTypeOnCell,
                                                CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                Attribute = InconsistentAttribute.Code
                                            });
                                        }

                                        break;
                                    case 2:
                                        if (GetCellValue(row.GetCell(j)).ToString() == null || string.IsNullOrWhiteSpace(GetCellValue(row.GetCell(j)).ToString()))
                                        {
                                            inconsistencies.Add(new Inconsistency
                                            {
                                                SpreadsheetID = spreadsheet,
                                                Collumn = j,
                                                Row = i,
                                                Type = InconsistencyType.MissingDataOnCell,
                                                CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                Attribute = InconsistentAttribute.Name
                                            });
                                        }
                                        else
                                        {
                                            product.Name = GetCellValue(row.GetCell(j)).ToString();
                                        }
                                        break;
                                    case 3:
                                        if (row.GetCell(j).CellType == CellType.Numeric)
                                        {
                                            if (row.GetCell(j).NumericCellValue < 0 || string.IsNullOrWhiteSpace(row.GetCell(j).NumericCellValue.ToString()))
                                            {
                                                product.Income = null;
                                            }
                                            else
                                            {
                                                if (DateUtil.IsCellDateFormatted(row.GetCell(j)))
                                                {
                                                    inconsistencies.Add(new Inconsistency
                                                    {
                                                        SpreadsheetID = spreadsheet,
                                                        Collumn = j,
                                                        Row = i,
                                                        Type = InconsistencyType.WrongDataTypeOnCell,
                                                        CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                        Attribute = InconsistentAttribute.Income
                                                    });
                                                }
                                                else
                                                {
                                                    product.Income = Convert.ToInt32(row.GetCell(j).NumericCellValue);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            inconsistencies.Add(new Inconsistency
                                            {
                                                SpreadsheetID = spreadsheet,
                                                Collumn = j,
                                                Row = i,
                                                Type = InconsistencyType.WrongDataTypeOnCell,
                                                CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                Attribute = InconsistentAttribute.Income
                                            });
                                        }
                                        break;
                                    case 4:
                                        if (row.GetCell(j).CellType == CellType.Numeric)
                                        {
                                            if (row.GetCell(j).NumericCellValue < 0 || string.IsNullOrWhiteSpace(row.GetCell(j).NumericCellValue.ToString()))
                                            {
                                                product.Outcome = null;
                                            }
                                            else
                                            {
                                                if (DateUtil.IsCellDateFormatted(row.GetCell(j)))
                                                {
                                                    inconsistencies.Add(new Inconsistency
                                                    {
                                                        SpreadsheetID = spreadsheet,
                                                        Collumn = j,
                                                        Row = i,
                                                        Type = InconsistencyType.WrongDataTypeOnCell,
                                                        CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                        Attribute = InconsistentAttribute.Outcome
                                                    });
                                                }
                                                else
                                                {
                                                    product.Outcome = Convert.ToInt32(row.GetCell(j).NumericCellValue);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            inconsistencies.Add(new Inconsistency
                                            {
                                                SpreadsheetID = spreadsheet,
                                                Collumn = j,
                                                Row = i,
                                                Type = InconsistencyType.WrongDataTypeOnCell,
                                                CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                Attribute = InconsistentAttribute.Outcome
                                            });
                                        }
                                        break;
                                    case 5:
                                        if (row.GetCell(j).CellType == CellType.Numeric)
                                        {
                                            if (row.GetCell(j).NumericCellValue < 0 || string.IsNullOrWhiteSpace(row.GetCell(j).NumericCellValue.ToString()))
                                            {
                                                inconsistencies.Add(new Inconsistency
                                                {
                                                    SpreadsheetID = spreadsheet,
                                                    Collumn = j,
                                                    Row = i,
                                                    Type = InconsistencyType.MissingDataOnCell,
                                                    CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                    Attribute = InconsistentAttribute.Stock
                                                });
                                            }
                                            else
                                            {
                                                if (DateUtil.IsCellDateFormatted(row.GetCell(j)))
                                                {
                                                    inconsistencies.Add(new Inconsistency
                                                    {
                                                        SpreadsheetID = spreadsheet,
                                                        Collumn = j,
                                                        Row = i,
                                                        Type = InconsistencyType.WrongDataTypeOnCell,
                                                        CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                        Attribute = InconsistentAttribute.Stock
                                                    });
                                                }
                                                else
                                                {
                                                    product.Stock = Convert.ToInt32(row.GetCell(j).NumericCellValue);
                                                }
                                            } 
                                        }
                                        else
                                        {
                                            inconsistencies.Add(new Inconsistency
                                            {
                                                SpreadsheetID = spreadsheet,
                                                Collumn = j,
                                                Row = i,
                                                Type = InconsistencyType.WrongDataTypeOnCell,
                                                CellValue = GetCellValue(row.GetCell(j)).ToString(),
                                                Attribute = InconsistentAttribute.Stock
                                            });
                                        }
                                        break;
                                    default: break;
                                }
                            }
                            else
                            {
                                InconsistentAttribute _attr = InconsistentAttribute.Date;

                                switch (j)
                                {
                                    case 0: _attr = InconsistentAttribute.Company;
                                        break;
                                    case 1: _attr = InconsistentAttribute.Code;
                                        break;
                                    case 2: _attr = InconsistentAttribute.Name;
                                        break;
                                    case 3: _attr = InconsistentAttribute.Income;
                                        break;
                                    case 4: _attr = InconsistentAttribute.Outcome;
                                        break;
                                    case 5: _attr = InconsistentAttribute.Stock;
                                        break;
                                }
                                if(_attr != InconsistentAttribute.Income && _attr != InconsistentAttribute.Outcome)
                                {
                                    inconsistencies.Add(new Inconsistency
                                    {
                                        SpreadsheetID = spreadsheet,
                                        Collumn = j,
                                        Row = i,
                                        Type = InconsistencyType.MissingDataOnCell,
                                        CellValue = null,
                                        Attribute = _attr
                                    });
                                }                                
                            }

                            if(inconsistencyCount == inconsistencies.Count)
                            {
                                products.Add(product);

                                if (row.GetCell(j) != null)
                                    sb.Append("<td>" + row.GetCell(j).ToString() + "</td>");
                                else
                                    sb.Append("<td></td>");
                            }
                            else
                            {
                                if (row.GetCell(j) != null)
                                    sb.Append("<td style='background: red;'>" + row.GetCell(j).ToString() + "</td>");
                                else
                                    sb.Append("<td style='background: red;'></td>");
                            }
                                

                            inconsistencyCount = inconsistencies.Count;

                            
                        }
                        sb.AppendLine("</tr>");
                    }
                    sb.Append("</table>");
                }
            }             

            foreach(Product _product in products)
            {
                if (ModelState.IsValid)
                {
                    var productInDb = _context.Products.FirstOrDefault(p => p.Code == _product.Code);
                    if(productInDb != null)
                        _context.Entry(productInDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;

                    if (_product.ID == 0 && productInDb == null)
                    {
                        _product.AddType = AddType.Excel;
                        _product.DateAdded = spreadsheet.ReferenceDate;
                        _context.Products.Add(_product);
                    }
                    else if(_product.Code == productInDb.Code)
                    {
                        productInDb.Code = _product.Code;
                        productInDb.Company = _product.Company;
                        productInDb.DateAdded = spreadsheet.ReferenceDate;
                        productInDb.Income = _product.Income;
                        productInDb.Name = _product.Name;
                        productInDb.Outcome = _product.Outcome;
                        productInDb.SpreadsheetId = spreadsheet;
                        productInDb.Stock = _product.Stock;
                        productInDb.EditType = AddType.Excel;
                        productInDb.LastEdit = DateTime.Now;
                        _context.Products.Update(productInDb);
                    }
                }                

                _context.SaveChanges();
            }
            
            _context.Inconsistencies.AddRange(inconsistencies);

            _context.SaveChanges();

            return this.Content(sb.ToString());
        }

        private object GetCellValue(ICell cell)
        {
            if (cell != null)
            {
                switch (cell.CellType)
                {
                    case CellType.String:
                        return cell.StringCellValue;
                    case CellType.Numeric:
                        if (DateUtil.IsCellDateFormatted(cell))
                            return cell.DateCellValue;
                        else
                            return cell.NumericCellValue;
                    case CellType.Boolean:
                        return cell.BooleanCellValue;
                    default:
                        return null;
                }
            }
            else
                return null;
        }
    }
}