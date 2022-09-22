using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC_2.Data;
using MVC_2.Models;

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


builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDBContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false; //true
    options.Password.RequireNonAlphanumeric = false; //true
    options.Password.RequireLowercase = false; // true;
    options.Password.RequiredUniqueChars = 1;
    options.Password.RequireUppercase = false; //true;
    options.Password.RequiredLength = 6;

});

builder.Services.AddRazorPages();


var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();

/*app.MapControllerRoute(
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
    name: "add",
    pattern: "add",
    defaults: new { controller = "People_", action = "Add" });

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
    defaults: new { controller = "GuessingGame", action = "GetSession" });*/

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


/*app.MapControllerRoute(
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
    defaults: new { controller = "Doctor", action = "FeverCheck" });*/


app.Run();
