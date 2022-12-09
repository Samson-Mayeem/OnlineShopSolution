using Microsoft.EntityFrameworkCore;
using ShopOnline.api.Repositories.Contracts;
using Mark.Up.Hub.api.Data;
using ShopOnline.api.Repositories;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//for mssql
//builder.Services.AddDbContext<DataContext>
               // (options => options.UseSqlServer(builder.Configuration.GetConnectionString("MarkCon")));

//for mysql
builder.Services.AddDbContext<DataContext>
                (options => options.UseMySql(builder.Configuration.GetConnectionString("conn"), new MySqlServerVersion(new Version())));

//To  be injected into each classin each Http request
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy =>
    policy.WithOrigins("http://localhost:7191", "https://localhost:7191")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
    );
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
