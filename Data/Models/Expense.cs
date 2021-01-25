using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetImpossibleManager.Data.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseID { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(80)] // tillåter inte en tom sträng. max 80 char.
        public string ExpenseName { get; set; }


        public DateTime TransactionDate { get; set; }
        
        public decimal ExpenseAmount { get; set; } 

        [ForeignKey("User")]
        public int UserID { get;  set;  }
        public User User { get;  set;  }

    }
}
