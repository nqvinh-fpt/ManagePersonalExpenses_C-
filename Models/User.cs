using System;
using System.Collections.Generic;

namespace ProjectPRN.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? DateOfBith { get; set; }
        public string? Password { get; set; }
        public int BudgetId { get; set; }

        public virtual Budget Budget { get; set; } = null!;
    }
}
