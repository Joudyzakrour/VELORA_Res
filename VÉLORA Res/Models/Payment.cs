using System;

namespace VÉLORA_Res.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public int OrderID { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;
    }
}