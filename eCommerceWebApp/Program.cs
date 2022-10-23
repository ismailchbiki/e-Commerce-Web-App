using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using eCommerceWebApp.Data;
using eCommerceWebApp.UseCases.PluginInterfaces.DataStore;
using eCommerceWebApp.DataStore.HardCoded;
using eCommerceWebApp.UseCases.SearchProductScreen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//whenever we need to have an implementation of the interface,
//this will create an instance of the provided (implementing) class
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ISearchProduct, SearchProduct>();
builder.Services.AddTransient<IViewProduct, ViewProduct>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
