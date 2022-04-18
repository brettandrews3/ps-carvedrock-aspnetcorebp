using CarvedRock_BlazorWebAssembly;
using CarvedRock_BlazorWebAssembly.Data;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

//builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri("https://localhost:7273") });
builder.Services.AddScoped<IProductApiService, ProductApiService>;

await builder.Build().RunAsync();
