using System;

namespace BackendPvTest.Models
{
    public class SellListResult
    {
        public int SellId { get; set; }
        public DateTime Date { get; set; }
        public double Quantity { get; set; }
        public decimal Total { get; set; }
    }
}