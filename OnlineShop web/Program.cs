using Mark.Up.Hub.web;
using Mark.Up.Hub.web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopOnline.web;
using ShopOnline.web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7143/") });
builder.Services.AddScoped<IProductServices, ProductService > ();
await builder.Build().RunAsync();
