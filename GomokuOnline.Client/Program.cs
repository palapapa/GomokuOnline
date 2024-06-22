using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Threading.Tasks;
using MudBlazor.Services;

namespace GomokuOnline.Client;

internal class Program
{
    private static async Task Main(string[] args)
    {
        WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.Services.AddMudServices();

        await builder.Build().RunAsync();
    }
}
