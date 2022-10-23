using EFCoreWithAPI.API.DbContextAPI;
using EFCoreWithAPI.API.DbContextAPI.Servises;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// life time to AddDbContext() is Scoped
builder.Services.AddDbContext<AppDbContextAPI>(options =>
              //options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EFCoreWithAPIDatabase")
              options.UseSqlServer(builder.Configuration["ConnectionStrings:EFCoreWithAPIConnectionString"])
);

builder.Services.AddScoped<IStudentRepository,StudentRepository>();

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
