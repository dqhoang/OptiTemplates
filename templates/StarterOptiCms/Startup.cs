using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Data;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace StarterOptiCms
{
    public class Startup
    {
        private readonly IWebHostEnvironment _webHostingEnvironment;
        private readonly IConfiguration _configuration;

        public Startup(IWebHostEnvironment webHostingEnvironment, IConfiguration configuration)
        {
            _webHostingEnvironment = webHostingEnvironment;
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            if (_webHostingEnvironment.IsDevelopment())
            {
#if (LocalDb)
                //Map App_Data to absolute value
                services.PostConfigure<DataAccessOptions>(o =>
                {
                    o.SetConnectionString(_configuration.GetConnectionString("EPiServerDB").Replace("App_Data", Path.GetFullPath("App_Data")));
                });
                services.PostConfigure<ApplicationOptions>(o =>
                {
                    o.ConnectionStringOptions.ConnectionString = _configuration.GetConnectionString("EPiServerDB").Replace("App_Data", Path.GetFullPath("App_Data"));
                });
#else
                //Add development configuration
#endif
            }

            services.AddMvc();
            services.AddCms()
                .AddCmsAspNetIdentity<ApplicationUser>();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/util/Login";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapContent();
            });
        }
    }
}