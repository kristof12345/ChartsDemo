using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using Microsoft.Extensions.Hosting;
using Common.Web;
using Webpage.Services;
using Common.Application.Models;
using System.Net.Http;
using System;

namespace WebApp.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration.GetSection("ServerSettings").Get<ServerSettings>());

            services.AddSignalR(e => { e.MaximumReceiveMessageSize = 102400000; });
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSyncfusionBlazor();

            services.AddSingleton(new HttpClient { BaseAddress = new Uri("https://localhost:5005/") });

            services.AddScoped<AppService>();
            services.AddScoped<ToastService>();
            services.AddScoped<ThemeService>();

            //Add services
            services.AddScoped<StockService>();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/Host");
            });
        }
    }
}
