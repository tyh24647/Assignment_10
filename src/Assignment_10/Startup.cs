using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.DependencyInjection;
using Assignment_10.Services;

namespace Assignment_10 {
    public class Startup {
        public Startup(IHostingEnvironment env) { }
        
        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
            services.AddSingleton<ISecurityProvider, SecurityProvider>();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            app.UseCors(policy => policy
                .AllowAnyHeader()
                .AllowAnyMethod()
                .WithOrigins("*")
                .WithExposedHeaders()
            );

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
