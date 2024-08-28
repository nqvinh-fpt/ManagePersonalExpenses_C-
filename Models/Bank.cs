using System;
using System.Collections.Generic;

namespace ProjectPRN.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Savings = new HashSet<Saving>();
        }

        public int BankId { get; set; }
        public int? BudgetId { get; set; }
        public string? BankName { get; set; }
        public decimal? BankPrice { get; set; }
        public string? Status { get; set; }

        public virtual Budget? Budget { get; set; }
        public virtual ICollection<Saving> Savings { get; set; }
    }
}
