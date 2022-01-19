using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models.Automapper;
using _20220107_HotelCleaning.Repositories;
using _20220107_HotelCleaning.Services;
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

namespace _20220107_HotelCleaning
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
            var defaultConnection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(x => x.UseSqlServer(defaultConnection));

            services.AddAutoMapper(typeof(HotelTaskProfile));
            services.AddAutoMapper(typeof(HotelTaskProfile_2));

            services.AddTransient<HotelRepository>();
            services.AddTransient<RoomRepository>();
            services.AddTransient<PersonRepository>();
            services.AddTransient<VisitorRepository>();
            services.AddTransient<BookingRepository>();
            services.AddTransient<CityRepository>();
            services.AddTransient<WorkerRepository>();
            services.AddTransient<JobTypeRepository>();
            services.AddTransient<TaskTypeRepository>();
            services.AddTransient<TaskRepository>();
            
            services.AddTransient<HotelService>();
            services.AddTransient<RoomService>();
            services.AddTransient<PersonService>();
            services.AddTransient<VisitorService>();
            services.AddTransient<BookingService>();
            services.AddTransient<CityService>();
            services.AddTransient<WorkerService>();
            services.AddTransient<JobTypeService>();
            services.AddTransient<TaskTypeService>();
            services.AddTransient<TaskService>();
            
            services.AddControllersWithViews();
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
                    pattern: "{controller=Hotel}/{action=Index}/{id?}");
            });
        }
    }
}
