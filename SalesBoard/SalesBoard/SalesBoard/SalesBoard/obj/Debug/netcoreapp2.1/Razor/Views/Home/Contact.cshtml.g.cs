#pragma checksum "C:\Users\Candi\Desktop\SalesBoard\SalesBoard\SalesBoard\SalesBoard\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78c523bdf25d42be744c81538b8e9ad98d25697d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\Candi\Desktop\SalesBoard\SalesBoard\SalesBoard\SalesBoard\Views\_ViewImports.cshtml"
using SalesBoard;

#line default
#line hidden
#line 2 "C:\Users\Candi\Desktop\SalesBoard\SalesBoard\SalesBoard\SalesBoard\Views\_ViewImports.cshtml"
using SalesBoard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78c523bdf25d42be744c81538b8e9ad98d25697d", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49f9950e13c8dbd8b8ecdf15ddac74afe365f24", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Candi\Desktop\SalesBoard\SalesBoard\SalesBoard\SalesBoard\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(48, 17, false);
#line 4 "C:\Users\Candi\Desktop\SalesBoard\SalesBoard\SalesBoard\SalesBoard\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(77, 19, false);
#line 5 "C:\Users\Candi\Desktop\SalesBoard\SalesBoard\SalesBoard\SalesBoard\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(96, 379, true);
            WriteLiteral(@"</h3>

<address>
    University<br />
    Drive North International Student Center<br />
    <abbr title=""Phone"">P:</abbr>
    400.700.000
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">Candice@example.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
</address>
");
            EndContext();
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
