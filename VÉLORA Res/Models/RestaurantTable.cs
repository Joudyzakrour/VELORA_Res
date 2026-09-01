using System;

namespace VÉLORA_Res.Models
{
    public class RestaurantTable
    {
        public int TableID { get; set; }

        public int TableNumber { get; set; }

        public int Capacity { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}