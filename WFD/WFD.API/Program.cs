using Microsoft.EntityFrameworkCore;
using WFD.Logic;
using WFD.Logic.Interfaces;
using WFD.Repository;

namespace WFD.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<WFDContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddControllers();

            // Add services to the container.
            //=============

            //builder.Services.AddScoped - tworzy coœ i przechowóje to przez chwilê
            //builder.Services.AddTransient - tworzy coœ i nie przechowóje
            //builder.Services.AddSingleton - tworzy 1 i trzyma go stale 


            builder.Services.AddScoped<Pesel>();
            builder.Services.AddScoped<Cz³owiek>();
            builder.Services.AddScoped<Student>();
            builder.Services.AddScoped<Robotnik>();
            builder.Services.AddSingleton<Uczelnia>();


            builder.Services.AddScoped<UserLogic>();

            builder.Services.AddScoped<IFoodLogic,FoodLogic>();





            //=============


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}