using DriveDomain;
using DriveManagement.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DriveManagement
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
            services.AddCors((builder) =>
            {
                builder.AddPolicy("corsPolicy", (b) =>
                 {
                     b.AllowAnyOrigin();
                     b.AllowAnyMethod();
                     b.AllowAnyHeader();
                 });
            });
            services.AddControllers().AddNewtonsoftJson();
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            DomainModule.RegisterSerives(services);
            services.AddSwaggerDocument();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseOpenApi();
            app.UseSwaggerUi3(options =>
            {
                options.DocumentTitle = "Drive Management";
            });
            app.UseCors("corsPolicy");

            app.UseMiddleware<AuthMidleware>();
            app.UseRouting();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "api/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}