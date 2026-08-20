namespace VÉLORA_Res.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public DateTime CreatedAt { get; set; }

      
    }
}