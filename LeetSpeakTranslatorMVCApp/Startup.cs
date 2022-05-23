using Business.CustomValidation;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace LeetSpeakTranslatorMVCApp
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
            services.AddDbContext<MyContext>(opts =>
            {
                opts.UseSqlServer(Configuration["ConnectionStrings:DefaultConnectionString"]);
            });
            services.AddIdentity<AppUser, AppRole>(opts =>
            {
                opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                opts.Password.RequiredLength = 4;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireDigit = false;
            }).AddPasswordValidator<CustomPasswordValidator>().AddEntityFrameworkStores<MyContext>().AddDefaultTokenProviders();

            CookieBuilder cookieBuilder = new CookieBuilder();
            cookieBuilder.Name = "MyBlog";
            cookieBuilder.HttpOnly = false;
            cookieBuilder.SameSite = SameSiteMode.Lax; //When cookie disappears
            cookieBuilder.SecurePolicy = CookieSecurePolicy.SameAsRequest;
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Home/Login"); //If visitor does not have a permission to the route, redirect to Login
                options.LogoutPath = new PathString("/Home/LogOut");//logout 
                options.Cookie = cookieBuilder;
                options.SlidingExpiration = true;     //When cookie time ends, if user sends request
                options.ExpireTimeSpan = TimeSpan.FromDays(60);     //
                options.AccessDeniedPath = new PathString("/Member/AccessDenied");  //Denying for registered users
            });

            services.AddMvc();
            services.AddRazorPages();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=LogIn}/{id?}");
            });
        }
    }
}
