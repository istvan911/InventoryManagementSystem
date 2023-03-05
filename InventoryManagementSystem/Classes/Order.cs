using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    [Table("Orders")]
    internal class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        [Required] public int ProductID { get; set; }
        [Required] public string ProductName { get; set; }
        [Required] public int Quantity { get; set; }
        [Required] public int UnitPrice { get; set; }
        [Required] public int TotalPrice { get; set; }
        [Required] public int CustomerID { get; set; }
        [Required] public string CustomerName { get; set; }
        [Required] public DateTime OrderDate { get; set; }
            
       
    }
}
