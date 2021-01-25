using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetImpossibleManager.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(80)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(80)]
        public string LastName { get; set; }
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }

        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<SavingGoal> SavingGoals { get; set; }
    }   
}
