#pragma checksum "C:\Users\ali.isenkul\Desktop\YMS5818\YMS8518\GuestBook\GuestBook\Views\GuestBook\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad6316e479ba15d75559895bbe2a12c4cea56128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GuestBook_Index), @"mvc.1.0.view", @"/Views/GuestBook/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GuestBook/Index.cshtml", typeof(AspNetCore.Views_GuestBook_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad6316e479ba15d75559895bbe2a12c4cea56128", @"/Views/GuestBook/Index.cshtml")]
    public class Views_GuestBook_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GuestBook.Data.Model.GuestNote>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ali.isenkul\Desktop\YMS5818\YMS8518\GuestBook\GuestBook\Views\GuestBook\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(77, 26, true);
            WriteLiteral("\r\n<h1>Ziyaretçi Defteri(<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 103, "\"", 143, 1);
#line 6 "C:\Users\ali.isenkul\Desktop\YMS5818\YMS8518\GuestBook\GuestBook\Views\GuestBook\Index.cshtml"
WriteAttributeValue("", 110, Url.Action("Manage","GuestBook"), 110, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(144, 27, true);
            WriteLiteral(">Yönetim</a>)</h1>\r\n<div>\r\n");
            EndContext();
#line 8 "C:\Users\ali.isenkul\Desktop\YMS5818\YMS8518\GuestBook\GuestBook\Views\GuestBook\Index.cshtml"
       
        foreach(var guestNote in Model)
        {

#line default
#line hidden
            BeginContext(232, 16, true);
            WriteLiteral("           <div>");
            EndContext();
            BeginContext(249, 17, false);
#line 11 "C:\Users\ali.isenkul\Desktop\YMS5818\YMS8518\GuestBook\GuestBook\Views\GuestBook\Index.cshtml"
           Write(guestNote.Message);

#line default
#line hidden
            EndContext();
            BeginContext(266, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(270, 14, false);
#line 11 "C:\Users\ali.isenkul\Desktop\YMS5818\YMS8518\GuestBook\GuestBook\Views\GuestBook\Index.cshtml"
                                Write(guestNote.Name);

#line default
#line hidden
            EndContext();
            BeginContext(284, 27, true);
            WriteLiteral("</div>\r\n           <br />\r\n");
            EndContext();
#line 13 "C:\Users\ali.isenkul\Desktop\YMS5818\YMS8518\GuestBook\GuestBook\Views\GuestBook\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(329, 1113, true);
            WriteLiteral(@"</div>
<div id=""GuestBook-Index-Form"">
    <form>
        <input type=""text"" id=""Name"" placeholder=""Adınız"" />
        <br />
        <input type=""text"" id=""Surname"" placeholder=""Soyadınız"" />
        <br />
        <input type=""email"" id=""Email"" placeholder=""E-posta adresiniz"" />
        <br />
        <textarea id=""Message"" placeholder=""Mesajınız...""></textarea>
        <br />
        <input type=""button"" value=""Gönder"" onclick=""GuestBook.Page.GuestBook.Index.Send();"" />
    </form>


</div>
<div id=""GuestBook-Index-Sending"" style=""display: none;"">
    <h3>Gönderiliyor...</h3>
</div>
<div id=""GuestBook-Index-Sent"" style=""display: none;"">
    <h3>Teşekkür Ederiz</h3>
</div>





























<em>
    …………………./´¯/)
    <br />

    ………………..,/¯../
    <br />
    ………………./…./
    <br />
    …………./´¯/’…’/´¯¯`·¸
    <br />
    ………./’/…/…./……./¨¯\
    <br />
    ……..(‘(…´…´…. ¯~/’…’)
    <br />
    ………\……………..’…../
    <br />
    ……….”…\……");
            WriteLiteral("…. _.·´\r\n    <br />\r\n    …………\\…………..(\r\n    <br />\r\n    …………..\\………….\\\r\n    <br />\r\n</em>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GuestBook.Data.Model.GuestNote>> Html { get; private set; }
    }
}
#pragma warning restore 1591
