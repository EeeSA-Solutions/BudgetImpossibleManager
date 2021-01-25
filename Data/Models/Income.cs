using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BudgetImpossibleManager.Data.Models
{
    public class Income
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false), MaxLength(80)]
        public string IncomeName { get; set; }
        public decimal IncomeAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public virtual User User { get; set; }
    }
}
