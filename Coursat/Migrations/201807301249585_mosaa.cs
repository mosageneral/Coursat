namespace Coursat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mosaa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserType");
        }
    }
}
