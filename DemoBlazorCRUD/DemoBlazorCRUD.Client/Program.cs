using DemoBlazorCRUD.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedLibrary.HealthEduRepositories;
using SharedLibrary.ProductRepositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<IProductRepository, ProductService>();
builder.Services.AddScoped<IHealthEduRepository, HealthEduService>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});
await builder.Build().RunAsync();