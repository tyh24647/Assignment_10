using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;

namespace Assignment_10 {
    public class Startup {
        public Startup(IHostingEnvironment env) { }
        
        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
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
