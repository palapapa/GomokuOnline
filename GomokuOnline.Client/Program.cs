using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using MudBlazor.Services;
using GomokuOnline.Client.Services;
using GomokuOnline.Client.Utilities;

namespace GomokuOnline.Client;

internal class Program
{
    private static async Task Main(string[] args)
    {
        WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.Services.AddSharedServices();

        await builder.Build().RunAsync();
    }
}
