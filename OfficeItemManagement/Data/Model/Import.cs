using System;

namespace OfficeItemManagement.Data.Model
{
    public class Import
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}