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
        // ����� ��� ������������ ������ (DI)
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<CalcService>();//������� ��������� ������ ��� ������� hhpt ������
            services.AddControllers();
            services.AddTransient< TimeService>();
        }
        //����� ��� ������������ ������� ������ HTTP
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // ������ ������������� ��� ����������
                endpoints.MapControllers();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                
            });
           
        }
    }
}
