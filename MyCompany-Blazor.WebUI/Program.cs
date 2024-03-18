using Microsoft.EntityFrameworkCore;
using MyCompany_Blazor.Server.Data;
using MyCompany_Blazor.WebUI.Interfaces;
using MyCompany_Blazor.WebUI.Services;
using MyCompany_Blazor.WebUI.Components;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add Radzen library to the container
builder.Services.AddRadzenComponents();

builder.Services.AddScoped<IDataService, DataService>();

// For prerendering purposes, register a named HttpClient for the app's
// named client component example.
// Add contexts to the container
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();