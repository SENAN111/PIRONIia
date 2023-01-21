internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();
        app.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=DashBoard}/{action=Index}/{id?}"
    );
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapControllerRoute(
           name: "Shop",
           pattern: "{controller=Shop}/{action=Index}/{id?}");
        app.MapControllerRoute(
          name: "Blog",
          pattern: "{controller=Shop}/{action=Index}/{id?}");
        app.MapControllerRoute(
         name: "AboutUs",
         pattern: "{controller=AboutUs}/{action=Index}/{id?}");
        app.MapControllerRoute(
         name: "ContactUs",
         pattern: "{controller=ContactUs}/{action=Index}/{id?}");



        app.Run();
    }
}