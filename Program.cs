using BudgetImpossibleManager.Data.Models;
using BudgetImpossibleManager.Data.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetImpossibleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingGoal savinggoal = new SavingGoal();
            savinggoal.GoalName = "resa";
            savinggoal.ReachDate = DateTime.Now;
            savinggoal.StartDate = DateTime.UtcNow;
            SavingGoalManager.CreateSavingGoal(savinggoal);

            //Bästa gruppen ever!
        }
    }
}
