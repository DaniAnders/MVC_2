var builder = WebApplication.CreateBuilder(args);

/* services mvc */
builder.Services.AddMvc();
/* Adding session */
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(1);
});


var app = builder.Build();

app.UseSession();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "index",
    pattern: "index",
    defaults: new { controller = "Home", action = "Index" });


app.MapControllerRoute(
    name: "about",
    pattern: "about",
    defaults: new { controller = "Home", action = "About" });


app.MapControllerRoute(
    name: "projects",
    pattern: "projects",
    defaults: new { controller = "Home", action = "Projects" });


app.MapControllerRoute(
    name: "contact",
    pattern: "contact",
    defaults: new { controller = "Home", action = "contact" });

app.MapControllerRoute(
    name: "fevercheck",
    pattern: "fevercheck",
    defaults: new { controller = "Doctor", action = "FeverCheck" });

app.MapControllerRoute(
    name: "guessinggame",
    pattern: "guessinggame",
    defaults: new { controller = "GuessingGame", action = "GuessingGame" });


app.MapControllerRoute(
    name: "getsession",
    pattern: "getsession",
    defaults: new { controller = "GuessingGame", action = "GetSession" });


app.Run();
