using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ServerApp.Data.EFCore;
using ServerApp.Models;
using ServerApp.Repositories.Data;
using System;

namespace ServerApp.Web
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
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString, b=> b.MigrationsAssembly("ServerApp.Web")));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ServerApp.Web", Version = "v1" });
            });

            services.AddScoped<ProductRepository>();
            services.AddScoped<SupplierRepository>();
            services.AddScoped<RatingRepository>();

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ServerApp.Web v1"));
            }

            app.UseHttpsRedirection();

            app.UseCors(options => options
            .WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //SeedData.SeedDatabase(services.GetRequiredService<AppDbContext>());
        }
    }
}
