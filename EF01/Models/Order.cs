﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF01.EF
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
            this.OrderDetails = new List<OrderDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        [MaxLength(5)]
        public string CustomerID { get;      set; }
        public int?      EmployeeID   { get; set; }
        public DateTime? OrderDate    { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate  { get; set; }
        public int?      ShipVia      { get; set; }
        public decimal?  Freight      { get; set; }
        [MaxLength(40)]
        public string ShipName { get; set; }
        [MaxLength(60)]
        public string ShipAddress { get; set; }
        [MaxLength(15)]
        public string ShipCity { get; set; }
        [MaxLength(15)]
        public string ShipRegion { get; set; }
        [MaxLength(10)]
        public string ShipPostalCode { get; set; }
        [MaxLength(15)]
        public string ShipCountry { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}