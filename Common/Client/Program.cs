using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Common.Application.Models;
using Common.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using Webpage.Services;

namespace WebApp.Client
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            var services = builder.Services;

            services.AddSingleton(builder.Configuration.GetSection("ServerSettings").Get<ServerSettings>());

            services.AddBlazoredLocalStorage();
            services.AddSyncfusionBlazor();

            services.AddScoped<AppService>();
            services.AddScoped<ToastService>();
            services.AddScoped<ThemeService>();

            //Add services
            services.AddScoped<StockService>();

            await builder.Build().RunAsync();
        }
    }
}
