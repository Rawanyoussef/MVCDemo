namespace MVCDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            #region 1
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are in Home Page");
            //    });

            //    endpoints.MapGet("/Products/{id?}", async context =>
            //    {
            //        var isDate = context.Request.RouteValues["id"];
            //        if(isDate is not null)
            //        {
            //            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //            await context.Response.WriteAsync($"Your reqest Product with id=>{id} ");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync($"Your are at product page");

            //        }

            //    });

            //endpoints.MapGet("/Products/{id}", async context =>
            //{
            //    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //    await context.Response.WriteAsync($"Your reqest Product with id=>{id} ");
            //});


            //  });




            //app.MapGet("/Home", () => "Hello World!");
            //app.MapGet("/Product", () => "Hello World!");
            //app.MapGet("/Category", () => "Hello World!");
            //app.MapGet("/Order", () => "Hello World!");

            #endregion
            app.MapControllerRoute(
                name: "default",
                pattern: "/{controller=Home}/{action=Index}",
               defaults: new { controller = "Home", Action = "Index" });

            app.Run();
        }
    }
}
