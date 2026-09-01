namespace VÉLORA_Res.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int TableID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime OrderDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public decimal Subtotal { get; set; }

        public decimal Discount { get; set; }

        public decimal Tax { get; set; }

        public decimal TotalAmount { get; set; }
    }
}