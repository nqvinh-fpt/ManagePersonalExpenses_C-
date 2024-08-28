using System;
using System.Collections.Generic;

namespace ProjectPRN.Models
{
    public partial class Income
    {
        public int IncomeId { get; set; }
        public int? BudgetId { get; set; }
        public string? IncomeName { get; set; }
        public string? DateStart { get; set; }
        public string? Description { get; set; }
        public decimal? IncomePrice { get; set; }
        public string? Status { get; set; }

        public virtual Budget? Budget { get; set; }
    }
}
