using System;

namespace _20220105_SEB_HomeWork.Models
{
    public class CurrencyModel
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public string Unit { get; set; }
        public decimal ChangePercentage { get; set; }
        public decimal LastRate { get; set; }
    }
}
