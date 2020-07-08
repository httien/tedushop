namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Products", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "MetaDescription", c => c.String(maxLength: 256));
            DropColumn("dbo.Products", "CraetedDate");
            DropColumn("dbo.Products", "MetaDesciption");
            DropColumn("dbo.ProductCategories", "CraetedDate");
            DropColumn("dbo.ProductCategories", "MetaDesciption");
            DropColumn("dbo.PostCategories", "Descripton");
            DropColumn("dbo.PostCategories", "CraetedDate");
            DropColumn("dbo.PostCategories", "MetaDesciption");
            DropColumn("dbo.Posts", "Descripton");
            DropColumn("dbo.Posts", "CraetedDate");
            DropColumn("dbo.Posts", "MetaDesciption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "MetaDesciption", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "CraetedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "Descripton", c => c.String(maxLength: 500));
            AddColumn("dbo.PostCategories", "MetaDesciption", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "CraetedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "Descripton", c => c.String(maxLength: 500));
            AddColumn("dbo.ProductCategories", "MetaDesciption", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "CraetedDate", c => c.DateTime());
            AddColumn("dbo.Products", "MetaDesciption", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "CraetedDate", c => c.DateTime());
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.Posts", "Description");
            DropColumn("dbo.PostCategories", "MetaDescription");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.PostCategories", "Description");
            DropColumn("dbo.ProductCategories", "MetaDescription");
            DropColumn("dbo.ProductCategories", "CreatedDate");
            DropColumn("dbo.Products", "MetaDescription");
            DropColumn("dbo.Products", "CreatedDate");
        }
    }
}
