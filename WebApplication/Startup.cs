using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Services;
using Core;
using DAL.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<IFixGroupDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IFixGroupDataBase"), x => x.MigrationsAssembly("DAL")));
            //services.AddDbContext<IFixGroupDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IFixGroupDataBase")));
            services.AddControllers();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IProjectTaskService, ProjectTaskService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
                {
                    endpoints.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync("Hello World!");
                    });
                    endpoints.MapControllers();
                });
        }
    }
}
