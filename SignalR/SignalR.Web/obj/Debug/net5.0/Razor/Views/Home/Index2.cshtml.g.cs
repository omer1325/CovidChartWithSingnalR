#pragma checksum "C:\Users\omer\source\repos\SignalR\SignalR.Web\Views\Home\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297eec5df4856ad300b0b7049e1d384487c68b3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index2), @"mvc.1.0.view", @"/Views/Home/Index2.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\omer\source\repos\SignalR\SignalR.Web\Views\_ViewImports.cshtml"
using SignalR.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omer\source\repos\SignalR\SignalR.Web\Views\_ViewImports.cshtml"
using SignalR.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297eec5df4856ad300b0b7049e1d384487c68b3a", @"/Views/Home/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e304c0afa9a0e898930a78a51a7a36ab26ffc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\omer\source\repos\SignalR\SignalR.Web\Views\Home\Index2.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/3.1.7/signalr.min.js""></script>
    <script type=""text/javascript"">
        var connection = new signalR.HubConnectionBuilder().withAutomaticReconnect([1000, 3000, 3000, 2000]).withUrl(""/MyHub"").build();
        connection.start().then(() => {
            console.log(connection.connectionState);
            connection.invoke(""SendMessage"", ""ilk mesaj"");
        }).catch((err) => { console.log(err) });

        connection.on(""ReceiveMessage"", (message) => {
            console.log(message);
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591