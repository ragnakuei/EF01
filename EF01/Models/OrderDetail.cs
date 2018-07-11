using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF01.EF
{
    [Table("Order Details")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public Single Discount { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }
    }
}