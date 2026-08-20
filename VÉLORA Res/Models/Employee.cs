using System;

namespace VÉLORA_Res.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string? Phone { get; set; }

        public string JobTitle { get; set; } = string.Empty;

        public decimal? Salary { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}