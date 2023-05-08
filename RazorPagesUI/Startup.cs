using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPagesUI.Models;

namespace RazorPagesUI
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
         services.AddDbContextPool<AppDbContext>(
            options => options.UseSqlServer(Configuration.GetConnectionString("AddressDbConnection")));
         
         services.AddRazorPages();
         //services.AddTransient<IAddressRepository, MockAddressRepository>();//In memory.
         //services.AddTransient<IAddressRepository, SqlAddressRepository>();
         
         /** 
          * Easier for unit testing. when we want to replace the real database with an IN MEMORY
          *  repository.
          */
         services.AddScoped<IAddressRepository, SqlAddressRepository>();
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
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
         }

         app.UseHttpsRedirection();
         app.UseStaticFiles();

         app.UseRouting();

         app.UseAuthorization();

         app.UseEndpoints(endpoints =>
         {
            endpoints.MapRazorPages();
         });
      }
   }
}
