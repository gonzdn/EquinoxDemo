using NetDevPack.Identity;
using NetDevPack.Identity.User;
using Equinox.Infra.CrossCutting.Identity;
using Equinox.UI.Web.Configurations;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// ConfigureServices

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
});

builder.Services.AddRazorPages();

// Setting DBContexts
builder.Services.AddDatabaseConfiguration(builder.Configuration);

// ASP.NET Identity Settings
builder.Services.AddWebAppIdentityConfiguration(builder.Configuration);

// Authentication & Authorization
builder.Services.AddSocialAuthenticationConfiguration(builder.Configuration);

var app = builder.Build();

// Configure

if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// NetDevPack.Identity dependency
app.UseAuthConfiguration();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
