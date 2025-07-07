namespace LeaveApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmailAddress", c => c.String());
            AddColumn("dbo.Employees", "EmployeeNumber", c => c.String());
            AddColumn("dbo.Employees", "CellphoneNumber", c => c.String());
            DropColumn("dbo.Employees", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Email", c => c.String());
            DropColumn("dbo.Employees", "CellphoneNumber");
            DropColumn("dbo.Employees", "EmployeeNumber");
            DropColumn("dbo.Employees", "EmailAddress");
        }
    }
}
