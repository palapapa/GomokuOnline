using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components.Web;

namespace GomokuOnline.Services;

/// <summary>
/// A helper services that lets you inject a <see cref="IWebAssemblyHostEnvironment"/> even if a component is using <see cref="RenderMode.InteractiveServer"/>.
/// </summary>
/// <param name="env">The <see cref="IWebHostEnvironment"/> to inject.</param>
/// <param name="nav">The <see cref="NavigationManager"/> to inject.</param>
class ServerWebAssemblyHostEnvironment(IWebHostEnvironment env, NavigationManager nav) : IWebAssemblyHostEnvironment
{
    public string Environment => env.EnvironmentName;
    public string BaseAddress => nav.BaseUri;
}
