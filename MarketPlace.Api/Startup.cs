using MarketPlace.Api.Brokers;
using MarketPlace.Api.Services.Foundations.Brands;
using MarketPlace.Api.Services.Foundations.Cars;
using MarketPlace.Api.Services.Foundations.Cities;
using MarketPlace.Api.Services.Foundations.Dealers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace MarketPlace.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var apiInfo = new OpenApiInfo
            {
                Title = "MarketPlace.Api",
                Version = "v1"
            };

            services.AddControllers();
            services.AddDbContext<StorageBroker>();
            AddBrokers(services);
            AddFoundationServices(services);

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    name: "v1",
                    info: apiInfo);
            });
        }

        private static void AddBrokers(IServiceCollection services) =>
            services.AddTransient<IStorageBroker, StorageBroker>();

        private static void AddFoundationServices(IServiceCollection services)
        {
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<IDealerService, DealerService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint(
                        url: "/swagger/v1/swagger.json",
                        name: "MarketPlace.Api v1");
                });
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
                endpoints.MapControllers());
        }
    }
}
