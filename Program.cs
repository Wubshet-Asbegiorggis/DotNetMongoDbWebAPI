using MongoDotnetDemo.Models;
using MongoDotnetDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<DatabaseSettings>(
     builder.Configuration.GetSection("MyDb")
    );
//resolving the CategoryService dependency here
builder.Services.AddTransient<ICategoryService,CategoryService>();
//resolving the ProductService dependency here
builder.Services.AddTransient<IProductService,ProductService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
