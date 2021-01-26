using BudgetImpossibleManager.Data;
using BudgetImpossibleManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetImpossibleManager.Managers
{
    class ExpenseManager
    {
        public void AddExpense(Expense expense)
        {
            using (var db = new BIMContext())
            {
                db.Expenses.Add(expense);
                db.SaveChanges();
            }
        }
        public Expense GetExpenseById(int id)
        {
            using (var db = new BIMContext())
            {
                var expense = db.Expenses.Find(id);
                return expense;
            }
        }
    }
}
