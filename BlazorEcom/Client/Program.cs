global using BlazorEcom.Shared;
global using Microsoft.AspNetCore.Mvc;
global using System.Net.Http.Json;
global using BlazorEcom.Client.Services.FoodService;
using BlazorEcom.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IFoodService, FoodService>();
await builder.Build().RunAsync();
