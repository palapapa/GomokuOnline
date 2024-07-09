using GomokuOnline.Components;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MudBlazor.Services;
using GomokuOnline.Client.Utilities;
using GomokuOnline.Hubs;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GomokuOnline.Services;

namespace GomokuOnline;

internal class Program
{
    private static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        builder.Services.AddSharedServices()
            .AddScoped<IWebAssemblyHostEnvironment, ServerWebAssemblyHostEnvironment>()
            .AddRazorComponents()
            .AddInteractiveServerComponents()
            .AddInteractiveWebAssemblyComponents();
        builder.Services.AddSignalRCore();
        WebApplication app = builder.Build();
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error")
                .UseHsts();
        }
        app.UseHttpsRedirection()
            .UseStaticFiles()
            .UseAntiforgery();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddInteractiveWebAssemblyRenderMode()
            .AddAdditionalAssemblies(typeof(Client.Components._Imports).Assembly);
        app.MapHub<GomokuHub>("/gomoku");
        app.Run();
    }
}
