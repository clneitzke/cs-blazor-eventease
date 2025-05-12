using Blazored.LocalStorage;
using EventEaseBlazor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddBlazoredLocalStorage(); // Register LocalStorage

await builder.Build().RunAsync();
