using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BudgetImpossibleManager.Data.Models
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }
        public decimal Fixedcost { get; set; }
        public decimal Groceries { get; set; }
        public decimal Entertainment { get; set; }
        public decimal Other { get; set; }

        public virtual User User { get; set; }
    }
}
