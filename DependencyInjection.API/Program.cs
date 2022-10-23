using DependencyInjection.API.Services;
using DependencyInjection.API.Services.Interfaces;
using Serilog;

namespace DependencyInjection.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // cunfiguration logger unsing serilog library
            Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.Information()
                        .WriteTo.Console()
                        .WriteTo.File("TestingLogger.txt" , rollingInterval : RollingInterval.Day)
                        .CreateLogger();


            var builder = WebApplication.CreateBuilder(args);

            // Clear logger configure and add new configure
            //builder.Logging.ClearProviders();
            //builder.Logging.AddConsole();

            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.AddTransient<FoodRepository>();

            builder.Host.UseSerilog();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //#if DEBUG
            //builder.Services.AddTransient<IFoodRepository, MockFoodRepository>();
            //#else
            //builder.Services.AddTransient<IFoodRepository, FoodRepository>();   
            //#endif


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
        }
    }
}