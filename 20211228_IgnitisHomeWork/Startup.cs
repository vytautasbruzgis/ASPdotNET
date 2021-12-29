using _20211228_IgnitisHomeWork.Data;
using _20211228_IgnitisHomeWork.Repositories;
using _20211228_IgnitisHomeWork.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20211228_IgnitisHomeWork
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            var defaultConnection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(x => x.UseSqlServer(defaultConnection));
            services.AddTransient<RegistrationAttributesRepository>();
            services.AddTransient<CalculationTypeRepository>();
            services.AddTransient<CustomerImportanceRepository>();
            services.AddTransient<ContractorTypeRepository>();
            services.AddTransient<RegistrationAttributesService>();
            services.AddTransient<ContractorTypeService>();
            services.AddTransient<CalculationTypeService>();
            services.AddTransient<CustomerImportanceService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
