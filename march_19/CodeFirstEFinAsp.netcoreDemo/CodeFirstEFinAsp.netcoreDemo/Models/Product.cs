using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEFinAsp.netcoreDemo.Models
{
    public class Product
    {
        public int ProductID { set; get; }

        [Required]
        public string ProductName { set; get; }

        [Display(Name ="Who Buyed")]
        [ForeignKey("Customer")]
        public int CustomerID { set; get; }
        public Customer Customer { set; get; }

    }
}
