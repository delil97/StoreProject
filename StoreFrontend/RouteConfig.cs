using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFrontend
{
    public static class RouteConfig
    {
        
        public static void SetRoutingAndEndPoints(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Entry Route");
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/hello/{name:alpha}", async context =>
                {
                    var name = context.Request.RouteValues["name"];
                    await context.Response.WriteAsync($"Hello {name}!");
                });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "ads",
                pattern: "ads/{year}/{month}",
                defaults: new { controller = "Ads", action = "Index" });
            }
          );
        }
    }
}
