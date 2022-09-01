using Microsoft.EntityFrameworkCore;
using MVC_2.Data;

var builder = WebApplication.CreateBuilder(args);

/* services mvc */
builder.Services.AddMvc();
/* Adding session */
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(1);
});

/* Adding Db context */
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});


var app = builder.Build();

app.UseSession();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "languages",
    pattern: "languages",
    defaults: new { controller = "Languages", action = "Languages" });


app.MapControllerRoute(
    name: "cities",
    pattern: "cities",
    defaults: new { controller = "Cities", action = "Cities" });


app.MapControllerRoute(
    name: "countries",
    pattern: "countries",
    defaults: new { controller = "Countries", action = "Countries" });

app.MapControllerRoute(
    name: "people_",
    pattern: "people_",
    defaults: new { controller = "People_", action = "People_" });

app.MapControllerRoute(
    name: "ajax",
    pattern: "ajax",
    defaults: new { controller = "Ajax", action = "Ajax" });


app.MapControllerRoute(
    name: "delete",
    pattern: "delete",
    defaults: new { controller = "People", action = "Delete" });


app.MapControllerRoute(
    name: "create",
    pattern: "create",
    defaults: new { controller = "People", action = "Create" });

app.MapControllerRoute(
    name: "people",
    pattern: "people",
    defaults: new { controller = "People", action = "People" });

app.MapControllerRoute(
    name: "guessinggame",
    pattern: "guessinggame",
    defaults: new { controller = "GuessingGame", action = "GuessingGame" });


app.MapControllerRoute(
    name: "getsession",
    pattern: "getsession",
    defaults: new { controller = "GuessingGame", action = "GetSession" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "index",
    pattern: "index",
    defaults: new { controller = "Home", action = "Index" });



app.MapControllerRoute(
    name: "projects",
    pattern: "projects",
    defaults: new { controller = "Home", action = "Projects" });


app.MapControllerRoute(
    name: "fevercheck",
    pattern: "fevercheck",
    defaults: new { controller = "Doctor", action = "FeverCheck" });


app.Run();
