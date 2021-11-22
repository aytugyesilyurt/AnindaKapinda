using Business;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MVC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddControllersWithViews();
            services.AddDbContext<AnindaKapindaDbContext>(options => options.UseSqlServer(@"Data Source=DESKTOP-K39TM3J;Database=AnindaKapindaDb;Trusted_Connection=true"));
            services.AddDALDependencies();

            services.AddTransient<IUserService, UserManager>();
            services.AddTransient<IProductService, ProductManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"));
        }
    }
}
