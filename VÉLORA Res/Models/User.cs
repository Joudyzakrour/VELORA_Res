namespace VÉLORA_Res.Models
{
    public class User
    {
        public int UserID { get; set; }

        public int EmployeeID { get; set; }

        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}