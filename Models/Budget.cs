using System;
using System.Collections.Generic;

namespace ProjectPRN.Models
{
    public partial class Budget
    {
        public Budget()
        {
            Banks = new HashSet<Bank>();
            Expenses = new HashSet<Expense>();
            Incomes = new HashSet<Income>();
            Users = new HashSet<User>();
        }

        public int BudgetId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? Status { get; set; }
        public int? ExpenseId { get; set; }

        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
