using Everis.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Everis.Models
{
    public class ProductCodeValidation : ValidationAttribute
    {
        private ProductsContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            _context = (ProductsContext)validationContext.GetService(typeof(ProductsContext));

            var product = (Product)validationContext.ObjectInstance;
            
            var productInDb = _context.Products.FirstOrDefault(p => p.Code == product.Code);

            //Não encontrou o produto no banco de dados
            if (productInDb == null)
                return ValidationResult.Success;
            //Encontrou o produto, e é o mesmo sendo editado
            else if(product.ID == productInDb.ID)
            {
                _context.Entry(productInDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                return ValidationResult.Success;
            }                
            //Encontrou outro produto com o mesmo código
            else
            {
                return new ValidationResult("Já existe um produto com este código no banco de dados.");
            }
        }

        public ValidationResult IsValidSpreadsheet(object value, ValidationContext validationContext)
        {
            _context = (ProductsContext)validationContext.GetService(typeof(ProductsContext));

            var product = (Product)value;

            var productInDb = _context.Products.FirstOrDefault(p => p.Code == product.Code);

            //Não encontrou o produto no banco de dados
            if (productInDb == null)
                return ValidationResult.Success;
            //Encontrou o produto, e é o mesmo sendo editado
            else if (product.ID == productInDb.ID)
            {
                _context.Entry(productInDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                return ValidationResult.Success;
            }
            //Encontrou outro produto com o mesmo código
            else
            {
                return new ValidationResult("Já existe um produto com este código no banco de dados.");
            }
        }

        internal bool IsValid(Product product, ProductsContext context)
        {
            _context = context;

            var productInDb = _context.Products.FirstOrDefault(p => p.Code == product.Code);

            if (productInDb == null)
                return true;
            //Encontrou o produto, e é o mesmo sendo editado
            else if (product.ID == productInDb.ID)
            {
                _context.Entry(productInDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                return true;
            }
            //Encontrou outro produto com o mesmo código
            else
            {
                return false;
            }
        }
    }
}
