#pragma checksum "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\RoomBooking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "477b4e4ac098339a47511862e4e25b2383223192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoomBooking_Index), @"mvc.1.0.view", @"/Views/RoomBooking/Index.cshtml")]
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
#line 1 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\_ViewImports.cshtml"
using Bongo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\_ViewImports.cshtml"
using Bongo.Models.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"477b4e4ac098339a47511862e4e25b2383223192", @"/Views/RoomBooking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0f048483d917611eaced43dd948685684e5974d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RoomBooking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudyRoomBooking>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1 class=""display-4"">Study Room Bookings</h1>

<hr />

<table class=""table table-striped table-bordered dt-responsive nowrap"">
    <thead class=""thead-light"">
        <tr>
            <th>Date</th>
            <th>Booking Id</th>
            <th>Room ID</th>
            <th>Email</th>
            <th>FirstName</th>
            <th>LastName</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\RoomBooking\Index.cshtml"
         foreach (var booking in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 21 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\RoomBooking\Index.cshtml"
           Write(booking.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 22 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\RoomBooking\Index.cshtml"
           Write(booking.BookingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 23 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\RoomBooking\Index.cshtml"
           Write(booking.StudyRoomId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\RoomBooking\Index.cshtml"
           Write(booking.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\RoomBooking\Index.cshtml"
           Write(booking.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\RoomBooking\Index.cshtml"
           Write(booking.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>");
#nullable restore
#line 27 "C:\Users\ricardo.garcia\OneDrive - Epicor\Documents\Cursos\Nunit\Nunit\Sparky\Bongo_InitialSetup (.NET 5)\Bongo.Web\Views\RoomBooking\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudyRoomBooking>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
