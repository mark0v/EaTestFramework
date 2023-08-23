using EaApplicationTest.Pages;
using EaFramework.Config;
using EaFramework.Driver;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaApplicationTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(ConfigReader.ReadConfig());
            services.AddScoped<IDriverFixture, DriverFixture>();
            services.AddScoped<IDriverWait, DriverWait>();
            services.AddScoped<IHomePage, HomePage>();
            services.AddScoped<IProductPage, ProductPage>();
        }
    }
}
