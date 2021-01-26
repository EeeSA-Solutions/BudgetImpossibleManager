namespace BudgetImpossibleManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LagttillExpenseManager : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Budgets", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Expenses", "UserID", "dbo.Users");
            DropForeignKey("dbo.Incomes", "User_Id", "dbo.Users");
            DropForeignKey("dbo.SavingGoals", "User_Id", "dbo.Users");
            RenameColumn(table: "dbo.Budgets", name: "User_Id", newName: "User_UserID");
            RenameColumn(table: "dbo.Incomes", name: "User_Id", newName: "User_UserID");
            RenameColumn(table: "dbo.SavingGoals", name: "User_Id", newName: "User_UserID");
            RenameIndex(table: "dbo.Budgets", name: "IX_User_Id", newName: "IX_User_UserID");
            RenameIndex(table: "dbo.Incomes", name: "IX_User_Id", newName: "IX_User_UserID");
            RenameIndex(table: "dbo.SavingGoals", name: "IX_User_Id", newName: "IX_User_UserID");
            DropPrimaryKey("dbo.Budgets");
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Incomes");
            AddColumn("dbo.Budgets", "BudgetID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Users", "UserID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Incomes", "IncomeID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Budgets", "BudgetID");
            AddPrimaryKey("dbo.Users", "UserID");
            AddPrimaryKey("dbo.Incomes", "IncomeID");
            AddForeignKey("dbo.Budgets", "User_UserID", "dbo.Users", "UserID");
            AddForeignKey("dbo.Expenses", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.Incomes", "User_UserID", "dbo.Users", "UserID");
            AddForeignKey("dbo.SavingGoals", "User_UserID", "dbo.Users", "UserID");
            DropColumn("dbo.Budgets", "Id");
            DropColumn("dbo.Users", "Id");
            DropColumn("dbo.Incomes", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Incomes", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Budgets", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.SavingGoals", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Incomes", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Expenses", "UserID", "dbo.Users");
            DropForeignKey("dbo.Budgets", "User_UserID", "dbo.Users");
            DropPrimaryKey("dbo.Incomes");
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Budgets");
            DropColumn("dbo.Incomes", "IncomeID");
            DropColumn("dbo.Users", "UserID");
            DropColumn("dbo.Budgets", "BudgetID");
            AddPrimaryKey("dbo.Incomes", "Id");
            AddPrimaryKey("dbo.Users", "Id");
            AddPrimaryKey("dbo.Budgets", "Id");
            RenameIndex(table: "dbo.SavingGoals", name: "IX_User_UserID", newName: "IX_User_Id");
            RenameIndex(table: "dbo.Incomes", name: "IX_User_UserID", newName: "IX_User_Id");
            RenameIndex(table: "dbo.Budgets", name: "IX_User_UserID", newName: "IX_User_Id");
            RenameColumn(table: "dbo.SavingGoals", name: "User_UserID", newName: "User_Id");
            RenameColumn(table: "dbo.Incomes", name: "User_UserID", newName: "User_Id");
            RenameColumn(table: "dbo.Budgets", name: "User_UserID", newName: "User_Id");
            AddForeignKey("dbo.SavingGoals", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Incomes", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Expenses", "UserID", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Budgets", "User_Id", "dbo.Users", "Id");
        }
    }
}
