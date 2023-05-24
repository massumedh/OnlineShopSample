using FluentMigrator;
using System.Data;

namespace OnlineShopSample.Migrations.Migrations
{
    [Migration(202305232132)]
    public class _202305232132_InitialOrderTable : Migration
    {
        public override void Up()
        {
            Create.Table("Orders")
                   .WithColumn("Id").AsInt32().PrimaryKey().Identity().NotNullable()
                   .WithColumn("DateOfIssue").AsDateTime().NotNullable()
                   .WithColumn("ProductCount").AsInt32().NotNullable()
                   .WithColumn("ProductPrice").AsDouble().NotNullable()
                   .WithColumn("TotalPrice").AsDouble().NotNullable()
                   .WithColumn("TotalProductCount").AsInt32().NotNullable()
                   .WithColumn("ProductId").AsInt32().NotNullable()
                   .ForeignKey("FK_Orders_Products", "Products", "Id")
                   .OnDelete(Rule.Cascade)
                   .WithColumn("CustomerId").AsInt32().NotNullable()
                   .ForeignKey("FK_Orders_Customers", "Customers", "Id")
                   .OnDelete(Rule.Cascade);
        }

        public override void Down()
        {
            Delete.Table("Orders");
        }
    }
}
