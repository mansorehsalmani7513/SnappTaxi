#pragma checksum "C:\Drive\Projects\OnlineTour\SnappTaxi\Snapp.Site\Views\Shared\Components\TransactInProcessComponent\TView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf6b63ffa27fb2e68f34dffadeb922da17811501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TransactInProcessComponent_TView), @"mvc.1.0.view", @"/Views/Shared/Components/TransactInProcessComponent/TView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TransactInProcessComponent/TView.cshtml", typeof(AspNetCore.Views_Shared_Components_TransactInProcessComponent_TView))]
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
#line 3 "C:\Drive\Projects\OnlineTour\SnappTaxi\Snapp.Site\Views\Shared\Components\TransactInProcessComponent\TView.cshtml"
using Snapp.Core.Scopes;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf6b63ffa27fb2e68f34dffadeb922da17811501", @"/Views/Shared/Components/TransactInProcessComponent/TView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TransactInProcessComponent_TView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Snapp.DataAccessLayer.Entites.Transact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(122, 665, true);
            WriteLiteral(@"
<div class=""header"">
    <h4 class=""title pull-right"">نمایش سفر های در حال انجام</h4>
    <h4 class=""title pull-left"">
    </h4>
    <div class=""clearfix""></div>
</div>
<div class=""content table-responsive table-full-width"">
    <table class=""table table-hover table-striped"">
        <thead>
            <tr>
                <th>
                    ساعت
                </th>
                <th>
                    مسافر
                </th>
                <th>
                    راننده
                </th>
                <th>
                    جمع کل
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 32 "C:\Drive\Projects\OnlineTour\SnappTaxi\Snapp.Site\Views\Shared\Components\TransactInProcessComponent\TView.cshtml"
             foreach (var item in Model)
            {
                string driverName = _tscope.GetUserById((Guid)item.DriverId).Username;


#line default
#line hidden
            BeginContext(934, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(981, 40, false);
#line 37 "C:\Drive\Projects\OnlineTour\SnappTaxi\Snapp.Site\Views\Shared\Components\TransactInProcessComponent\TView.cshtml"
                   Write(Html.DisplayFor(model => item.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1053, 44, false);
#line 38 "C:\Drive\Projects\OnlineTour\SnappTaxi\Snapp.Site\Views\Shared\Components\TransactInProcessComponent\TView.cshtml"
                   Write(Html.DisplayFor(model => item.User.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1129, 10, false);
#line 39 "C:\Drive\Projects\OnlineTour\SnappTaxi\Snapp.Site\Views\Shared\Components\TransactInProcessComponent\TView.cshtml"
                   Write(driverName);

#line default
#line hidden
            EndContext();
            BeginContext(1139, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1171, 25, false);
#line 40 "C:\Drive\Projects\OnlineTour\SnappTaxi\Snapp.Site\Views\Shared\Components\TransactInProcessComponent\TView.cshtml"
                   Write(item.Total.ToString("n0"));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 35, true);
            WriteLiteral(" ریال</td>\r\n                </tr>\r\n");
            EndContext();
#line 42 "C:\Drive\Projects\OnlineTour\SnappTaxi\Snapp.Site\Views\Shared\Components\TransactInProcessComponent\TView.cshtml"
            }

#line default
#line hidden
            BeginContext(1246, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public TransactScope _tscope { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Snapp.DataAccessLayer.Entites.Transact>> Html { get; private set; }
    }
}
#pragma warning restore 1591