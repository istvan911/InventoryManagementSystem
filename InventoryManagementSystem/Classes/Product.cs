using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    [Table("Products")]
    internal class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required] public string ProductName { get; set; }
        [Required] public int ProductQuantity { get; set; }
        [Required] public int ProductPrice { get; set; }
        [Required] public string ProductDescription { get; set; }
        [Required] public string CategoryName { get; set; }

    }
}
