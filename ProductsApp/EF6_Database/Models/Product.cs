using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF6_Database.Models
{
    public class Product
    {
        //public int Id { get; set; }
        [Key]
        [Required]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Content { get; set; }
    } // end of
}
