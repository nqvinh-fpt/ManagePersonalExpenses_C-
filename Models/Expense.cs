using System;
using System.Collections.Generic;

namespace ProjectPRN.Models
{
    public partial class Expense
    {
        public int ExpenseId { get; set; }
        public int? BudgetId { get; set; }
        public string? ExpenseName { get; set; }
        public string? Description { get; set; }
        public decimal? ExpensePrice { get; set; }
        public string? Date { get; set; }
        public string? Invoice { get; set; }

        public virtual Budget? Budget { get; set; }

        
    }


}
