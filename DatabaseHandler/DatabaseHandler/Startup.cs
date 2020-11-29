using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StarWars.Data.DbContexts;
using StarWars.Data.Repositories;
using StarWars.Data.Services;

namespace DatabaseHandler
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
            services.AddControllers(setupAction =>
            {
                setupAction.ReturnHttpNotAcceptable = true;
                setupAction.CacheProfiles.Add("240SecondsCacheProfile",
                    new CacheProfile()
                    {
                        Duration = 240
                    });
            });

            services.AddDbContext<SwContext>(options 
                => options.UseSqlServer(Configuration.GetConnectionString("StarWarsUniverse")));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<ICharacterRepository, CharacterRepository>();
            services.AddScoped<ISpeciesRepository, SpeciesRepository>();
            services.AddScoped<IAffiliationRepository, AffiliationRepository>();
            services.AddScoped<ILifeTimeRepository, LifeTimeRepository>();

            services.AddScoped<ICharacterService, CharacterService>();
            services.AddScoped<ISpeciesService, SpeciesService>();
            services.AddScoped<IAffiliationService, AffiliationService>();
            services.AddScoped<ILifeTimeService, LifeTimeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
