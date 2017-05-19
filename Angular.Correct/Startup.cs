using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace Angular.Correct
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // serve up wwwroot
            app.UseFileServer();

            // this will serve up node_modules
            var provider = new PhysicalFileProvider(
                Path.Combine(env.ContentRootPath, "node_modules")
            );
            var options = new FileServerOptions();
            options.RequestPath = "/node_modules";
            options.StaticFileOptions.FileProvider = provider;
            options.EnableDirectoryBrowsing = true;
            app.UseFileServer(options);
        }
    }
}
