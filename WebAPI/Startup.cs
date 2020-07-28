using Domain.Business;
using Domain.Interfaces.Business;
using Domain.Interfaces.Data;
using Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace WebAPI
{
    public class Startup
    {
        readonly string _schoolAPI = "SchoolAPI";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SchoolContext>(options =>
                options.UseSqlServer("Data Source = SchoolDB")
                , ServiceLifetime.Singleton);

            services.AddCors(options =>
            {
                options.AddPolicy(name: _schoolAPI,
                                  builder =>
                                  {
                                      builder
                                      .WithOrigins("http://localhost:4200", "https://localhost:4200");
                                  });
            });


            services.AddControllers();
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "School API",
                    Description = "School Manager WEB API - ASP.NET Core",
                });
            });

            //Business
            services.AddSingleton<ISchool_Business, School_Business>();
            services.AddSingleton<IClassRoom_Business, ClassRoom_Business>();

            //Data            
            services.AddSingleton<ISchoolRepository, SchoolRepository>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseCors(_schoolAPI);
            app.UseSwagger();
            app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "SchoolManager"));
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
