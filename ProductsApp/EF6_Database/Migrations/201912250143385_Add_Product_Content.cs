namespace EF6_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Product_Content : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Content", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Content");
        }
    }
}
