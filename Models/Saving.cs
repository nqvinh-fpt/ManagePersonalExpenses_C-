using System;
using System.Collections.Generic;

namespace ProjectPRN.Models
{
    public partial class Saving
    {
        public int SaveId { get; set; }
        public int? BankId { get; set; }
        public string? SaveName { get; set; }
        public string? DateStart { get; set; }
        public string? Interest { get; set; }
        public string? Description { get; set; }
        public decimal? SavePrice { get; set; }
        public string? Status { get; set; }

        public virtual Bank? Bank { get; set; }
    }
}
