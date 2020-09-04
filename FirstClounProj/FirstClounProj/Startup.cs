using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace FirstClounProj
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc(); .......................for mvc architict
            //services.AddControllers(); ............... for API architict
            services.AddControllersWithViews(); //........use this for now
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); //...for telling program to use static files(css,js,img...) from wwwroot
           
            //app.UseStaticFiles(new StaticFileOptions() {
            //  FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"MyStaticFiles")),
            //  RequestPath= "/MyStaticFiles"
            //});//...for telling program to use static files(css,js,img...) not from wwwroot from another file
          
            app.UseRouting();

            app.UseEndpoints(Endpoint=> {
                Endpoint.MapDefaultControllerRoute();
            });


            //for learning comments.............

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/Finish", async context =>
            //    {
            //        await context.Response.WriteAsync("finish");
            //    });
            //});

            //app.Use(async (context,next) => {
            //    await context.Response.WriteAsync("First");
            //    await next();
            //    await context.Response.WriteAsync(" First First");
            //});
            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync(" Second");
            //    await next();
            //    await context.Response.WriteAsync(" Second Second");
            //});
            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync(" Third");
            //    await next();
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/", async context =>
            //    {
            //        //await context.Response.WriteAsync(env.EnvironmentName);

            //        if (env.IsDevelopment())
            //        {
            //            await context.Response.WriteAsync("IsDevelopment");
            //        }
            //        else if (env.IsEnvironment("Production"))
            //        {
            //            await context.Response.WriteAsync("Yes it i Production");
            //        }

            //    });
            //});

        }
    }
}
