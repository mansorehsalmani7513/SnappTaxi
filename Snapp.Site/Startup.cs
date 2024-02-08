using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Snapp.Core.Scopes;
using Snapp.Core.Interfaces;
using Snapp.Core.Services;

using Snapp.DataAccessLayer.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Snapp.Site.Hubs;

namespace Snapp.Site
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            #region AddDbContext

            services.AddDbContext<DatabaseContext>(options =>
           {
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
           });

            #endregion

            #region Authentication

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = "/Account/Register";
                options.LogoutPath = "/Account/SignOut";
                options.ExpireTimeSpan = TimeSpan.FromDays(30);
            });

            #endregion

            #region AddScope

            services.AddScoped<IAccount, AccountService>();
            services.AddScoped<IAdmin, AdminService>();
            services.AddScoped<IPanel, PanelService>();
            services.AddScoped<SiteLayoutScope>();
            services.AddScoped<TransactScope>();

            #endregion

            #region Add Service

            services.AddMvc(option => option.EnableEndpointRouting = false);

            services.AddSignalR();

            #endregion


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseMvcWithDefaultRoute();
            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapHub<ChatHub>("/chathub");
            });
        }
    }
}
