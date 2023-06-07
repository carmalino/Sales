using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Sales.Web;
using Sales.Web.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7011/") });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7050/") });
//builder.Services.AddScoped<IRepository,Repository>();

builder.Services.AddHttpClient<IRepository, Repository>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7011/");
});

builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
