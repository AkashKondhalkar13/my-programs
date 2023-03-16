using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstCRUDef.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Product Name Required.")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Category ID Required.")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name  Required.")]
        public string CategoryName { get; set; }
    }
    public class EFCodeFirst : DbContext
    {
        public DbSet<Products> products { get; set; }
    }
}