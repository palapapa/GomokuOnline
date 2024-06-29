using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace GomokuOnline.Client.Services;

/// <summary>
/// Helper class to output to the browser console.
/// </summary>
/// <param name="jsRuntime">The IJSRuntime to use.</param>
public class JsConsole(IJSRuntime jsRuntime) : IJsConsole
{
    private readonly IJSRuntime jsRumtime = jsRuntime;

    /// <inheritdoc cref="IJsConsole.Log(object)"/>
    public async ValueTask Log(object? message) => await jsRumtime.InvokeVoidAsync("console.log", message);
}
