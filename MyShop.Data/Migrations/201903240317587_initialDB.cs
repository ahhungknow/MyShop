namespace MyShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.About",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(nullable: false, maxLength: 50),
                    Details = c.String(nullable: false, storeType: "ntext"),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Account",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 50),
                    Password = c.String(nullable: false, maxLength: 50),
                    Name = c.String(nullable: false, maxLength: 50),
                    Address = c.String(nullable: false, maxLength: 250),
                    Phone = c.String(nullable: false, maxLength: 10),
                    Email = c.String(nullable: false, maxLength: 250),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Banner",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Image = c.String(nullable: false, maxLength: 500),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.BillDetail",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    BillId = c.Int(nullable: false),
                    ProductId = c.Int(nullable: false),
                    Amount = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Bill",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CreateDate = c.DateTime(storeType: "date"),
                    CustomerId = c.Int(nullable: false),
                    ShipAddress = c.String(nullable: false, maxLength: 250),
                    Status = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Category",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    Link = c.String(nullable: false, maxLength: 250),
                    ParentId = c.Int(nullable: false),
                    Order = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Customer",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    Address = c.String(nullable: false, maxLength: 250),
                    Phone = c.String(nullable: false, maxLength: 10),
                    Email = c.String(nullable: false, maxLength: 250),
                    Status = c.Boolean(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 50),
                    Password = c.String(maxLength: 50),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Footer",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Content = c.String(nullable: false, storeType: "ntext"),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Menu",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    Link = c.String(nullable: false, maxLength: 50),
                    Order = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.New",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(nullable: false, maxLength: 50),
                    Link = c.String(nullable: false, maxLength: 250),
                    CategoryId = c.Int(),
                    Description = c.String(nullable: false, storeType: "ntext"),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Product",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    Link = c.String(nullable: false, maxLength: 250),
                    Description = c.String(nullable: false, storeType: "ntext"),
                    Image = c.String(nullable: false, maxLength: 500),
                    Quanity = c.Int(nullable: false),
                    ViewCount = c.Int(nullable: false),
                    CategoryId = c.Int(),
                    ShowOnHome = c.Boolean(nullable: false),
                    Special = c.Boolean(nullable: false),
                    Sale = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Slide",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Image = c.String(nullable: false, maxLength: 500),
                    Link = c.String(nullable: false, maxLength: 250),
                    Order = c.Int(nullable: false),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Slide");
            DropTable("dbo.Product");
            DropTable("dbo.New");
            DropTable("dbo.Menu");
            DropTable("dbo.Footer");
            DropTable("dbo.Customer");
            DropTable("dbo.Category");
            DropTable("dbo.Bill");
            DropTable("dbo.BillDetail");
            DropTable("dbo.Banner");
            DropTable("dbo.Account");
            DropTable("dbo.About");
        }
    }
}