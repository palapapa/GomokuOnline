using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace GomokuOnline.Client.Services;

/// <summary>
/// Represents a browser console.
/// </summary>
public interface IJsConsole
{
    /// <summary>
    /// Logs an object to the browser console.
    /// </summary>
    /// <param name="message">A JSON-serializable object to log.</param>
    /// <returns>Return value of <see cref="JSRuntimeExtensions.InvokeVoidAsync(IJSRuntime, string, object?[])"/></returns>
    public ValueTask Log(object message);
}
