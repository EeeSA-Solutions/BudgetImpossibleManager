using BudgetImpossibleManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BudgetImpossibleManager.Data.Managers
{
    public static class SavingGoalManager
    {
        static public void CreateSavingGoal(SavingGoal savinggoal)
        {
            using (var db = new BIMContext())
            {
                db.SavingGoals.Add(savinggoal);
                db.SaveChanges();
            }


        }
    }
}
