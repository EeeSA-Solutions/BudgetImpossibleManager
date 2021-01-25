namespace BudgetImpossibleManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fixedcost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Groceries = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Entertainment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Other = c.Decimal(nullable: false, precision: 18, scale: 2),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 80),
                        LastName = c.String(nullable: false, maxLength: 80),
                        Email = c.String(),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ExpenseID = c.Int(nullable: false, identity: true),
                        ExpenseName = c.String(nullable: false, maxLength: 80),
                        TransactionDate = c.DateTime(nullable: false),
                        ExpenseAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExpenseID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncomeName = c.String(nullable: false, maxLength: 80),
                        IncomeAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionDate = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.SavingGoals",
                c => new
                    {
                        SavingGoalID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        ReachDate = c.DateTime(nullable: false),
                        GoalName = c.String(nullable: false, maxLength: 80),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.SavingGoalID)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SavingGoals", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Incomes", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Expenses", "UserID", "dbo.Users");
            DropForeignKey("dbo.Budgets", "User_Id", "dbo.Users");
            DropIndex("dbo.SavingGoals", new[] { "User_Id" });
            DropIndex("dbo.Incomes", new[] { "User_Id" });
            DropIndex("dbo.Expenses", new[] { "UserID" });
            DropIndex("dbo.Budgets", new[] { "User_Id" });
            DropTable("dbo.SavingGoals");
            DropTable("dbo.Incomes");
            DropTable("dbo.Expenses");
            DropTable("dbo.Users");
            DropTable("dbo.Budgets");
        }
    }
}
