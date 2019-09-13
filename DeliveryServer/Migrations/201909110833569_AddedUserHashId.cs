namespace DeliveryServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserHashId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserHashId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UserHashId");
        }
    }
}
