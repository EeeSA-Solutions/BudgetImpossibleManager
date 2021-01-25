using BudgetImpossibleManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetImpossibleManager.Data
{
    public class BIMContext : DbContext
    {
        public BIMContext() : base ("name=BudgetImpossibleManagerConnectionsString")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<SavingGoal> SavingGoals { get; set; }
    }
}
