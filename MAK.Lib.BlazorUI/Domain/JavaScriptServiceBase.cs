using System;
using System.Threading.Tasks;

using Microsoft.JSInterop;

namespace Domain
{
    public class JavaScriptServiceBase
    {
        public JavaScriptServiceBase(IJSRuntime jsRuntime) => this.ModuleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(ImportJS, JavaScriptFile).AsTask());

        protected readonly Lazy<Task<IJSObjectReference>> ModuleTask;
        protected const string ImportJS = "import";
        public static string JavaScriptFile { get; set; }
    }
}
