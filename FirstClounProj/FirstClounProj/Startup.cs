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
            services.AddControllersWithViews();

#if DEBUG  //this if code just to applay on development environment, another will applay on all environment which makes pgm bad performence
            // this code just for development environment(debug mode)
            //change from debu to release in debuging up to see if work
            services.AddRazorPages().AddRazorRuntimeCompilation(); // to make razor compilation take place in compliation pgm , for accept any chage in view pages without build pgm again and again
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); //...for telling program to use static files(css,js,img...) from wwwroot
            app.UseRouting();

            app.UseEndpoints(endpoint=> {
                endpoint.MapDefaultControllerRoute();
                // for testing f url and navigation is correct een if we type anything befor controler in url
                //endpoint.MapControllerRoute(
                //name: "Default",
                //pattern: "FirstCorMVCProj/{controller=Home}/{action=Index}/{id?}"
                //);
            });

        }
    }
}
