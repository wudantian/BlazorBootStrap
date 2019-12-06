using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBootstrap.Common
{
    public static class ExtensionMethods
    {
     public static async Task Focus(this ElementReference element,IJSRuntime jsRuntime)
    {
        await jsRuntime.InvokeVoidAsync("dateTimePickerFunctions.focusElement", element);
    }
   }
}
