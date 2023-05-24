using FluentMigrator;

namespace OnlineShopSample.Migrations.Migrations
{
    [Migration(202305232140)]
    public class _202305232140_InitialCustomerTable : Migration
    {
        public override void Up()
        {
            Create.Table("Customers")
                   .WithColumn("Id").AsInt32().PrimaryKey().Identity().NotNullable()
                   .WithColumn("FirstName").AsString().NotNullable()
                   .WithColumn("LastName").AsString().NotNullable()
                   .WithColumn("MobileNumber").AsString(11).NotNullable();

        }
        public override void Down()
        {
            Delete.Table("Customers");
        }
    }
}
