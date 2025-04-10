var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve static files from wwwroot/
app.UseStaticFiles();

// Redirect root URL "/" to index.html
app.MapGet("/", async context =>
{
    context.Response.Redirect("/index.html");
});

app.Run();
