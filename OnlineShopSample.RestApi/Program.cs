using Microsoft.EntityFrameworkCore;
using OnlineShopSample.Persistence.EF.Commons;
using OnlineShopSample.Services.Categories;
using OnlineShopSample.Services.Categories.Contracts;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SqlServer");
builder.Services.AddDbContext<EFDataContext>(
    options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<CategoryService, CategoryAppService>();

var app = builder.Build();   
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
