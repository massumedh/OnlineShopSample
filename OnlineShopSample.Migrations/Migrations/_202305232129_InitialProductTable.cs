using FluentMigrator;

namespace OnlineShopSample.Migrations.Migrations
{
    [Migration(202305232129)]
    public class _202305232129_InitialProductTable : Migration
    {
        public override void Up()
        {
            Create.Table("Products")
                .WithColumn("Id").AsInt32().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Inventory").AsInt32().NotNullable()
                .WithColumn("Price").AsDouble().NotNullable()
                .WithColumn("MinimumInventoryLevel").AsInt32().NotNullable()
                .WithColumn("Status").AsByte().NotNullable()
                .WithColumn("CategoryId").AsInt32().NotNullable()
                .ForeignKey("FK_Products_Categories", "Categories", "Id");
        }

        public override void Down()
        {
            Delete.Table("Products");
        }
    }
}
