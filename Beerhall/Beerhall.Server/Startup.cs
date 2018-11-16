using Beerhall.Core;
using Beerhall.Infrastructure;
using Microsoft.AspNetCore.Blazor.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Beerhall.Server
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Adds the Server-Side Blazor services, and those registered by the app project's startup.
            services.AddDbContext<BreweryDbContext>(options => options.UseSqlite("Data Source=beerhall.db"));
            services.AddScoped<IBrewerManager, BrewerManager>();
            services.AddScoped<ICustomerManager, CustomerManager>();
            services.AddServerSideBlazor<App.Startup>();

            services.AddResponseCompression(options =>
            {
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                {
                    MediaTypeNames.Application.Octet,
                    WasmMediaTypeNames.Application.Wasm,
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, BreweryDbContext context)
        {
            context.Database.EnsureCreated();
            InitializeData(context);

            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Use component registrations and static files from the app project.
            app.UseServerSideBlazor<App.Startup>();
        }
        private void InitializeData(BreweryDbContext context)
        {
            if (context.Brewers.Any())
            {
                return;
            }
            List<Brewer> brewers = new List<Brewer>();

            for (int i = 0; i < 2000; i++)
            {
                Address address = new Address($"Street {i}", $"Country {i}");
                brewers.Add(new Brewer($"Brewer {i}", $"Some Description for brewer {i}", $"brewer{i}@gnail.com", address, DateTime.UtcNow));
            }
            context.AddRange(brewers);

            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 2000; i++)
            {
                Address address = new Address($"Street {i}", $"Country {i}");
                customers.Add(new Customer($"Brewer {i}", $"BE {i}",address));
            }
            context.AddRange(customers);
            context.SaveChanges();
        }
    }
}
