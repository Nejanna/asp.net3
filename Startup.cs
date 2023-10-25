using lab3.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    public class Startup
    {
        // Метод для налаштування сервісів (DI)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<CalcService>();//окремий екземпляр служби для кожного hhpt запиту
            services.AddControllers();
            services.AddTransient< TimeService>();
        }
        //метод для налаштування конвеєра запиту HTTP
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Додаємо маршрутизацію для контролерів
                endpoints.MapControllers();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                
            });
           
        }
    }
}
