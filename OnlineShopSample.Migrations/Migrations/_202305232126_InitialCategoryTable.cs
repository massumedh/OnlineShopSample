using FluentMigrator;

namespace OnlineShopSample.Migrations.Migrations
{
    [Migration(202305232126)]
    public class _202305232126_InitialCategoryTable : Migration
    {
        public override void Up()
        {
            Create.Table("Categories")
                  .WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Identity()
                  .WithColumn("Title").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Categories");
        }
    }
}
